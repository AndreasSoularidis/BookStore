using BookStoreAPI.Entities;

namespace BookStoreAPI.DTOs
{
    public class OrderDTO
    {
        private decimal _totalPrice;
        public List<BasketItemDTO> BasketItems { get; set; } = [];
        public DateTime OrderDate { get; set; }
        public decimal TotalPrice
        {
            set
            {
                _totalPrice = BasketItems.Sum(x => x.Price * x.Quantity);
            }
            get
            {
                return _totalPrice;
            }
        }
        public string Status { get; set; } = String.Empty;  
    }
}
