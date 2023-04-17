namespace examNextJsBackEnd.Entities
{
    public class Restaurant
    {
        public string Id { get; set; } = string.Empty;

        public string Name { get; set; } = string.Empty;


        public List<FoodItem> FoodItems = new List<FoodItem>();


        public List<Cart> Carts = new List<Cart>();

        public DateTimeOffset CreatedAt { get; set; }
    }
}
