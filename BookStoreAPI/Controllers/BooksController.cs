using BookStoreAPI.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookStoreAPI.Controllers
{
    [Route("api/books")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private BooksDataStore _booksStore;

        public BooksController(BooksDataStore booksStore)
        {
            _booksStore = booksStore;
        }

        [HttpGet]
        public ActionResult<IEnumerable<BookDTO>> GetBooks()
        {
            return Ok(_booksStore.Books);
        }

        [HttpGet("bookId")]
        public ActionResult<BookDTO> GetBook(Guid id)
        {
            var books = _booksStore.Books;

            var bookToReturn = books.FirstOrDefault(b => b.Id == id);

            if (bookToReturn == null)
            {
                return NotFound();
            }

            return Ok(bookToReturn);
        }
    }
}
