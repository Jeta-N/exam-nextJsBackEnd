using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using examNextJsBackEnd.Entities;
using examNextJsBackend.Models;
using Microsoft.AspNetCore.Authorization;
using static OpenIddict.Abstractions.OpenIddictConstants;

namespace examNextJsBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public CartsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Carts
        [HttpGet]
        public async Task<ActionResult<List<CartItemModel>>> GetCarts(string restaurantId)
        {
            if (_context.Carts == null)
            {
                return NotFound();
            }
            return await _context.Carts
                .AsNoTracking()
                .Where(Q => Q.RestaurantId == restaurantId)
                .Select(Q => new CartItemModel
                {
                    Id = Q.Id,
                    RestaurantId = Q.RestaurantId
                })
                .ToListAsync();
        }

        // GET: api/Carts/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CartItemModel>> GetCart(string id)
        {
            if (_context.Carts == null)
            {
                return NotFound();
            }
            var cart = await _context.Carts.
                AsNoTracking()
                .Where(Q => Q.Id == id)
                .Select(Q => new CartItemModel
                {
                    Id = Q.Id,
                    RestaurantId = Q.RestaurantId
                }).FirstOrDefaultAsync();

            if (cart == null)
            {
                return NotFound();
            }

            return cart;
        }

        // PUT: api/Carts/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCart(string id, Cart cart)
        {
            if (id != cart.Id)
            {
                return BadRequest();
            }

            _context.Entry(cart).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CartExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Carts
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost(Name = "addToCart")]
        [Authorize("api")]
        public async Task<ActionResult<Cart>> PostCart(AddToCartModel cart)
        {
            if (_context.Carts == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Carts'  is null.");
            }

            var userId = User.FindFirst(Claims.Subject)?.Value ?? throw new InvalidOperationException("User ID not found");

            var existing = await _context.Carts
                .Where(Q => Q.RestaurantId == cart.RestaurantId && Q.UserId == userId)
                .FirstOrDefaultAsync();

            
            if (existing == null)
            {
                var newCart = new Cart
                {
                    Id = Ulid.NewUlid().ToString(),
                    RestaurantId = cart.RestaurantId,
                    UserId = userId,
                    CreatedAt = DateTimeOffset.Now
                };
                _context.Carts.Add(newCart);
                await _context.SaveChangesAsync();
                return newCart;
            }
            else
            {
                return existing;
            }
        }

        // DELETE: api/Carts/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCart(string id)
        {
            if (_context.Carts == null)
            {
                return NotFound();
            }
            var cart = await _context.Carts.FindAsync(id);
            if (cart == null)
            {
                return NotFound();
            }

            _context.Carts.Remove(cart);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CartExists(string id)
        {
            return (_context.Carts?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
