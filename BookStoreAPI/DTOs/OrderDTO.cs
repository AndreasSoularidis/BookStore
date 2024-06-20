using BookStoreAPI.Entities;

namespace BookStoreAPI.DTOs
{
    public class OrderDTO
    {
        private decimal _totalPrice;
        public Basket OrderItem { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalPrice 
        {
            set
            {
                _totalPrice = OrderItem.TotalCost;
            }
            get
            {
                return _totalPrice;
            }
        }
        public string Status { get; set; } = String.Empty;  
    }
}
