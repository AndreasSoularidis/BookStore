using BookStoreAPI.Entities;

namespace BookStoreAPI.DTOs
{
    public class UserDTO
    {
        public String Id { get; set; } = String.Empty;
        public string FirstName { get; set; } = String.Empty;
        public string LastName { get; set; } = String.Empty;
        public string UserName { get; set; } = String.Empty;
        public string Email { get; set; } = String.Empty;
        public ICollection<OrderDTO> Orders { get; set; } = [];
        public BasketDTO? Basket { get; set; }
    }
}
