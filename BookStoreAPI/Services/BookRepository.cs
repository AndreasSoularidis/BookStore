using BookStoreAPI.Entities;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace BookStoreAPI.Services
{
    public class BookRepository : IBookRepository
    {
        private readonly IMongoCollection<Book> _bookCollection;

        public BookRepository(MongoDBContext context)
        {
            _bookCollection = context.Books ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<Book> GetBookByIdAsync(string bookId)
        {
            return await _bookCollection.Find(b => b.Id == bookId).FirstOrDefaultAsync();
        }

        public async Task<List<Book>> GetBookListAsync()
        {
            return await _bookCollection.Find(_ => true).ToListAsync();
        }

        public async Task AddBookAsync(Book book)
        {
            await _bookCollection.InsertOneAsync(book);
        }
    }
}
