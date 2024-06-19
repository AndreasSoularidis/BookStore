using BookStoreAPI.Entities;

namespace BookStoreAPI.Services
{
    public interface IUserRepository
    {
        public Task<List<User>> GetUserListAsync();
        public Task<User> GetUserByIdAsync(string id);
        public Task<bool> UserExistsAsync(string userId);
        public Task AddUserAsync(User user);
        public void DeleteUser(string userId);
    }
}
