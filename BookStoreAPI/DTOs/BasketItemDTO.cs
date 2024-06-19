namespace BookStoreAPI.DTOs
{
    public class BasketItemDTO
    {
        public string BookId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}
