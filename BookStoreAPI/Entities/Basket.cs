namespace BookStoreAPI.Entities
{
    public class Basket
    {
        public List<BasketItem> BasketItem { get; set; } = [];
        public decimal TotalCost { get; set; }
    }
}
