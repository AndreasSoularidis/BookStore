namespace BookStoreAPI.Entities
{
    public class Basket
    {
        public int Id { get; set; }
        public List<BasketItem> BasketItem { get; set; } = [];
        public decimal TotalCost { get; set; }
    }
}
