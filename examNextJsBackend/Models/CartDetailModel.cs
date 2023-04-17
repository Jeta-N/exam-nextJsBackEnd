namespace examNextJsBackend.Models
{
    public class CartDetailModel
    {
        public string Id { get; set; } = string.Empty;
        public string CartId { get; set; } = string.Empty;
        public string FoodItemId { get; set; } = string.Empty;

        public string FoodName { get; set; } = string.Empty;
        public decimal FoodPrice { get; set; } 
        public int Quantity { get; set; }
    }
}
