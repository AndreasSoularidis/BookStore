using BookStoreAPI.Entities;

namespace BookStoreAPI.Services
{
    public interface IUserRepository
    {
        public Task<List<User>> GetUserListAsync();
        public Task<User> GetUserByIdAsync(string id);
        public Task<bool> UserExistsAsync(string userId);
        public Task AddUserAsync(User user);
        public Task UpdateUserAsync(string userId, User user);
        public void DeleteUser(string userId);
        public Task<Basket> GetUserBasketAsync(string userId);
        public Task AddUserBasketItemAsync(string userId, BasketItem item);
        public void RemoveBasketItemAsync(string userId, string basketItemId);
        public Task<IEnumerable<Order>> GetUserOrdersAsync(string userId);
        public Task AddUserOrderAsync(string userId, Order order);
    }
}
