using AutoMapper;
using BookStoreAPI.DTOs;
using BookStoreAPI.Entities;
using BookStoreAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace BookStoreAPI.Controllers
{
    [Route("api/users/{userId}/basket")]
    [ApiController]
    public class BasketController : ControllerBase
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public BasketController(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository ?? throw new ArgumentNullException(nameof(userRepository));
            _mapper = mapper ?? throw new ArgumentNullException();
        }

        [HttpGet]
        public async Task<ActionResult<BasketDTO>> GetBasket(string userId)
        {
            if (!await _userRepository.UserExistsAsync(userId)) 
            {
                return NotFound();
            }

            var basket = await _userRepository.GetUserBasketAsync(userId);
            
            return Ok(_mapper.Map<BasketDTO>(basket));
        }

        [HttpPost]
        public async Task<ActionResult<BasketDTO>> AddBasketItem(string userId, BasketItemDTO item)
        {
            if (!await _userRepository.UserExistsAsync(userId))
            {
                return NotFound();
            }

            var itemToBeInserted = _mapper.Map<BasketItem>(item);

            await _userRepository.AddUserBasketItemAsync(userId, itemToBeInserted);

            var basket = await _userRepository.GetUserBasketAsync(userId);

            var basketToBeReturned = _mapper.Map<BasketDTO>(basket);

            return CreatedAtAction(nameof(GetBasket), new { userId}, basketToBeReturned);

        }

        [HttpDelete("bookId")]
        public async Task<ActionResult> RemoveBasketItem(string userId, string bookId)
        {
            if (!await _userRepository.UserExistsAsync(userId))
            {
                return NotFound();
            }

             _userRepository.RemoveBasketItemAsync(userId, bookId);

            return NoContent();
        }
    }
}
