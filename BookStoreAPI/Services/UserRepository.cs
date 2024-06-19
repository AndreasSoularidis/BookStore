using BookStoreAPI.Entities;
using MongoDB.Driver;

namespace BookStoreAPI.Services
{
    public class UserRepository : IUserRepository
    {
        private readonly IMongoCollection<User> _userCollection;

        public UserRepository(MongoDBContext context) 
        {
            _userCollection = context.Users ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<List<User>> GetUserListAsync()
        {
            return await _userCollection.Find(_ => true).ToListAsync();
        }

        public async Task<User> GetUserByIdAsync(string id)
        {
            return await _userCollection.Find(u => u.Id == id).FirstOrDefaultAsync();
        }

        public async Task<bool> UserExistsAsync(string userId)
        {
            var user = await _userCollection.Find(u => u.Id == userId).FirstOrDefaultAsync();

            if (user == null) 
            {
                return false;
            }
            return true;
        }

        public async Task AddUserAsync(User user)
        {
            await _userCollection.InsertOneAsync(user);
        }

        public async void DeleteUser(string userId)
        {
            await _userCollection.DeleteOneAsync(u => u.Id == userId);
        }
    }
}
