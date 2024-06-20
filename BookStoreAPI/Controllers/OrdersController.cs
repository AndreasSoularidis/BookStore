using AutoMapper;
using BookStoreAPI.DTOs;
using BookStoreAPI.Entities;
using BookStoreAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookStoreAPI.Controllers
{
    [Route("api/users/{userId}/orders")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public OrdersController(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository ?? throw new ArgumentNullException(nameof(userRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<OrderDTO>>> GetOrders(string userId)
        {
            if (!await _userRepository.UserExistsAsync(userId))
            {
                return NotFound();
            }

            var orders = await _userRepository.GetUserOrdersAsync(userId);

            return Ok(_mapper.Map<IEnumerable<OrderDTO>>(orders));
        }

        [HttpPost]
        public async Task<ActionResult<OrderDTO>> AddOrder(string userId, BasketDTO item)
        {
            if (!await _userRepository.UserExistsAsync(userId))
            {
                return NotFound();
            }

            var now = DateTime.UtcNow;
            var status = "In Process";

            var basketToBeInserted = _mapper.Map<Basket>(item);

            var orderToBeInserted = new Order()
            {
                UserId = userId,
                OrderItem = basketToBeInserted,
                OrderDate = now,
                Status = status,
                TotalPrice = basketToBeInserted.TotalCost
            };


            await _userRepository.AddUserOrderAsync(userId, orderToBeInserted);

            var order = await _userRepository.GetUserOrdersAsync(userId);

            var orderToBeReturned = _mapper.Map<List<OrderDTO>>(order);

            return CreatedAtAction(nameof(GetOrders), new { userId }, orderToBeReturned);

        }
    }
}
