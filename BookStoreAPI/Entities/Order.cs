namespace BookStoreAPI.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public List<BasketItem> BasketItems { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalPrice { get; set; }
        public string Status { get; set; }
    }
}
