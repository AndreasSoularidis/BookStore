using AutoMapper;
using BookStoreAPI.DTOs;
using BookStoreAPI.Entities;
using BookStoreAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookStoreAPI.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public UsersController(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserDTO>>> getUsers()
        {
            var users = await _userRepository.GetUserListAsync();
            
            return Ok(_mapper.Map<IEnumerable<UserDTO>>(users));
        }

        [HttpGet("userid")]
        public async Task<ActionResult<UserDTO>> GetUser(string userId)
        {
            var user = await _userRepository.GetUserByIdAsync(userId);

            if (user == null) 
            {
                return NotFound();
            }

            return Ok(_mapper.Map<UserDTO>(user));
        }

        [HttpPost]
        public async Task<ActionResult<UserDTO>> InsertUser(InsertNewUserDTO newUser)
        {
            var userToBeInserted = _mapper.Map<User>(newUser);

            await _userRepository.AddUserAsync(userToBeInserted);

            var userToBeReturned = _mapper.Map<UserDTO>(userToBeInserted);

            return CreatedAtAction(nameof(GetUser), new { userToBeReturned.Id}, userToBeReturned);
        }

        [HttpPut("userId")]
        public async Task<ActionResult> UpdateUser(string userId, UpdateUserDTO user)
        {
            if (!await _userRepository.UserExistsAsync(userId))
            {
                return NotFound();
            }

            var userEntity = await _userRepository.GetUserByIdAsync(userId);

            if (userEntity == null)
            {
                return NotFound();
            }

            //var updatedUser =  _mapper.Map<User>(user);

            var updatedUser = _mapper.Map(user, userEntity);

            updatedUser.Id = userEntity.Id;

            await _userRepository.UpdateUserAsync(userId, updatedUser);

            return NoContent();
        }
    }
}
