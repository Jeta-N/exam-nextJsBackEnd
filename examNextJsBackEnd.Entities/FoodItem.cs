using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examNextJsBackEnd.Entities
{
    public class FoodItem
    {
        public string Id { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;

        public decimal Price { get; set; }

        public string RestaurantId { get; set; } = string.Empty;

        public Restaurant Restaurants { get; set; } = null!;

        public List<CartDetail> CartDetails { get; set; } = new List<CartDetail>();

        public DateTimeOffset CreatedAt { get; set; }
    }
}
