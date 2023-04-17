using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examNextJsBackEnd.Entities
{
    public class CartDetail
    {
        public string Id { get; set; } = string.Empty;

        public string CartId { get; set; } = string.Empty;

        public Cart Cart { get; set; } = null!;

        public string FoodItemId { get; set; } = string.Empty;

        public FoodItem FoodItem { get; set; } = null!;

        public int Quantity { get; set; }

        public DateTimeOffset CreatedAt { get; set; }
    }
}
