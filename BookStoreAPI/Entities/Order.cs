namespace BookStoreAPI.Entities
{
    public class Order
    {
        public string UserId { get; set; }
        public Basket OrderItem { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalPrice { get; set; }
        public string Status { get; set; }
    }
}
