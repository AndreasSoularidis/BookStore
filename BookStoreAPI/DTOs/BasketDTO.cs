using BookStoreAPI.Entities;

namespace BookStoreAPI.DTOs
{
    public class BasketDTO
    {
        private decimal _totalCost;
        public ICollection<BasketItemDTO> BasketItem { get; set; } = [];
        public decimal TotalCost
        {
            set
            {
                _totalCost = BasketItem.Sum(c => c.Quantity * c.Price);

            }
            get 
            {
                return _totalCost;
            }

        }
    }
}
