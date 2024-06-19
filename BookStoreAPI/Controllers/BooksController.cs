using AutoMapper;
using BookStoreAPI.DTOs;
using BookStoreAPI.Entities;
using BookStoreAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;

namespace BookStoreAPI.Controllers
{
    [Route("api/books")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IBookRepository _bookRepository;
        private readonly IMapper _mapper;

        public BooksController(IBookRepository bookRepository, IMapper mapper)
        {
            _bookRepository = bookRepository ?? throw new ArgumentNullException(nameof(bookRepository));
            _mapper = mapper;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Book>>> GetBooks()
        {
            var books = await _bookRepository.GetBookListAsync();

            return Ok(_mapper.Map<IEnumerable<BookDTO>>(books));
        }

        [HttpGet("bookId")]
        public async Task<ActionResult<BookDTO>> GetBook(string id)
        {
            var book = await _bookRepository.GetBookByIdAsync(id);

            if (book == null)
            {
                return NotFound();
            }

            return Ok(book);
        }

        [HttpPost]
        public async Task<ActionResult<BookDTO>> AddBook(InsertNewBookDTO newBook)
        {
            var bookToBeInserted = _mapper.Map<Book>(newBook);

            await _bookRepository.AddBookAsync(bookToBeInserted);

            var bookToBeReturned = _mapper.Map<DTOs.BookDTO>(bookToBeInserted);

            return CreatedAtAction(nameof(GetBook), new { id = bookToBeReturned.Id }, bookToBeReturned);
        }
    }
}
