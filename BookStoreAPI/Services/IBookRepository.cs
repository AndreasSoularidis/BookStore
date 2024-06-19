using BookStoreAPI.Entities;

namespace BookStoreAPI.Services
{
    public interface IBookRepository
    {
        public Task<List<Book>> GetBookListAsync();
        public Task<Book> GetBookByIdAsync(string bookId);
        public Task AddBookAsync(Book book);
    }
}
