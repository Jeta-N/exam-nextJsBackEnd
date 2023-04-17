namespace examNextJsBackend.Models
{
    public class AddToCartDetailModel
    {
        public string Id { get; set; } = string.Empty;

        public string CartId { get; set; } = string.Empty;
        public string FoodItemId { get; set; } = string.Empty;

        public int Quantity { get; set; }

    }
}
