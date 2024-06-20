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

        public async Task UpdateUserAsync(string userId, User user)
        {
            await _userCollection.ReplaceOneAsync(u => u.Id == userId, user);
        }

        // Basket
        public async Task<Basket> GetUserBasketAsync(string userId)
        {
            var user = await _userCollection.Find(u => u.Id == userId).FirstOrDefaultAsync();
            return user.Basket ?? new Basket();
        }

        public async Task AddUserBasketItemAsync(string userId, BasketItem item)
        {
            var filter = Builders<User>.Filter.Eq(user => user.Id, userId);
            var user = await _userCollection.Find(filter).FirstOrDefaultAsync();

            if (user != null)
            {
                if (user.Basket == null)
                {
                    user.Basket = new Basket();
                }

                user.Basket.BasketItem.Add(item);
                await _userCollection.ReplaceOneAsync(filter, user);
            }
        }

        public async void RemoveBasketItemAsync(string userId, string bookId)
        {
            var filter = Builders<User>.Filter.Eq(user => user.Id, userId);
            var update = Builders<User>.Update.PullFilter(user => user.Basket.BasketItem, item => item.BookId == bookId);

            await _userCollection.UpdateOneAsync(filter, update);
        }

        public async Task<IEnumerable<Order>> GetUserOrdersAsync(string userId)
        {
            var user = await _userCollection.Find(u => u.Id == userId).FirstOrDefaultAsync();

            return user.Orders;
        }

        public async Task AddUserOrderAsync(string userId, Order newOrder)
        {
            var filter = Builders<User>.Filter.Eq(user => user.Id, userId);
            var user = await _userCollection.Find(filter).FirstOrDefaultAsync();

            if (user != null)
            {
                if (user.Orders == null)
                {
                    user.Orders = new();
                }

                user.Orders.Add(newOrder);
                await _userCollection.ReplaceOneAsync(filter, user);
            }
        }
    }
}
