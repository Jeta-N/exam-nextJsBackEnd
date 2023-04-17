using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.DataProtection.EntityFrameworkCore;
using static OpenIddict.Abstractions.OpenIddictConstants;

namespace examNextJsBackEnd.Entities
{
    public class ApplicationDbContext : DbContext, IDataProtectionKeyContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var restaurantA = new Restaurant
            {
                Id = "01GY6PXNZBB0JSS61Q2JDBBJJJ",
                Name = "McDonalds",
                CreatedAt = DateTimeOffset.Now,
            };
            var restaurantB = new Restaurant
            {
                Id = "01GY6PXNZBCNQCQGZ7KQSG7F84",
                Name = "KFC",
                CreatedAt = DateTimeOffset.Now,
            };
            var restaurantC = new Restaurant
            {
                Id = "01GY6Q8FKXS2QB405HFMV8MVT2",
                Name = "A&W",
                CreatedAt = DateTimeOffset.Now
            };
            modelBuilder.Entity<Restaurant>().HasData(restaurantA, restaurantB, restaurantC);

            var foodA = new FoodItem
            {
                Id = Ulid.NewUlid().ToString(),
                Name = "Food A Restaurant A",
                RestaurantId = "01GY6PXNZBB0JSS61Q2JDBBJJJ",
                Price = 50000,
                CreatedAt = DateTimeOffset.Now,
            };
            var foodB = new FoodItem
            {
                Id = Ulid.NewUlid().ToString(),
                Name = "Food B Restaurant A",
                RestaurantId = "01GY6PXNZBB0JSS61Q2JDBBJJJ",
                Price = 25000,
                CreatedAt = DateTimeOffset.Now,
            };
            var drinkA = new FoodItem
            {
                Id = Ulid.NewUlid().ToString(),
                Name = "Drink A Restaurant A",
                RestaurantId = "01GY6PXNZBB0JSS61Q2JDBBJJJ",
                Price = 5000,
                CreatedAt = DateTimeOffset.Now,
            };
            var drinkB = new FoodItem
            {
                Id = Ulid.NewUlid().ToString(),
                Name = "Drink B Restaurant A",
                RestaurantId = "01GY6PXNZBB0JSS61Q2JDBBJJJ",
                Price = 10000,
                CreatedAt = DateTimeOffset.Now,
            };

            var foodC = new FoodItem
            {
                Id = Ulid.NewUlid().ToString(),
                Name = "Food A Restaurant B",
                RestaurantId = "01GY6PXNZBCNQCQGZ7KQSG7F84",
                Price = 28000,
                CreatedAt = DateTimeOffset.Now
            };

            var foodD = new FoodItem
            {
                Id = Ulid.NewUlid().ToString(),
                Name = "Food B Restaurant B",
                RestaurantId = "01GY6PXNZBCNQCQGZ7KQSG7F84",
                Price = 45000,
                CreatedAt = DateTimeOffset.Now
            };

            var drinkC = new FoodItem
            {
                Id = Ulid.NewUlid().ToString(),
                Name = "Drink A Restaurant B",
                RestaurantId = "01GY6PXNZBCNQCQGZ7KQSG7F84",
                Price = 15000,
                CreatedAt = DateTimeOffset.Now
            };

            var drinkD = new FoodItem
            {
                Id = Ulid.NewUlid().ToString(),
                Name = "Drink B Restaurant B",
                RestaurantId = "01GY6PXNZBCNQCQGZ7KQSG7F84",
                Price = 25000,
                CreatedAt = DateTimeOffset.Now
            };

            var foodE = new FoodItem
            {
                Id = Ulid.NewUlid().ToString(),
                Name = "Food A Restaurant C",
                RestaurantId = "01GY6Q8FKXS2QB405HFMV8MVT2",
                Price = 58000,
                CreatedAt = DateTimeOffset.Now
            };

            var foodF = new FoodItem
            {
                Id = Ulid.NewUlid().ToString(),
                Name = "Food B Restaurant C",
                RestaurantId = "01GY6Q8FKXS2QB405HFMV8MVT2",
                Price = 35000,
                CreatedAt = DateTimeOffset.Now
            };

            var drinkE = new FoodItem
            {
                Id = Ulid.NewUlid().ToString(),
                Name = "Drink A Restaurant C",
                RestaurantId = "01GY6Q8FKXS2QB405HFMV8MVT2",
                Price = 17000,
                CreatedAt = DateTimeOffset.Now
            };

            var drinkF = new FoodItem
            {
                Id = Ulid.NewUlid().ToString(),
                Name = "Drink B Restaurant C",
                RestaurantId = "01GY6Q8FKXS2QB405HFMV8MVT2",
                Price = 27000,
                CreatedAt = DateTimeOffset.Now
            };
            modelBuilder.Entity<FoodItem>().HasData(foodA, foodB, foodC, foodD, foodE, foodF, drinkA, drinkB, drinkC, drinkD, drinkE, drinkF);
        }

        public DbSet<User> Users => Set<User>();
        public DbSet<Restaurant> Restaurants => Set<Restaurant>();
        public DbSet<FoodItem> FoodItems => Set<FoodItem>();
        public DbSet<Cart> Carts => Set<Cart>();
        public DbSet<CartDetail> CartDetails => Set<CartDetail>();
        public DbSet<DataProtectionKey> DataProtectionKeys => Set<DataProtectionKey>();
    }
}
