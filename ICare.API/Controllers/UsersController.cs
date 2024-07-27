using ICare.Application.DTOs;
using ICare.Application.Interfaces;
using ICare.Domain;
using Microsoft.AspNetCore.Mvc;

namespace ICare.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserRepository _userRepository;

        public UsersController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetUsers()
        {
            var users = await _userRepository.GetAllAsync();
            return Ok(users);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetUserById(Guid id)
        {
            return Ok(await _userRepository.GetByIdAsync(id));
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser([FromBody] UserDTO userDto)
        {
            if (userDto == null)
            {
                return BadRequest();
            }

            var result = await _userRepository.AddAsync(userDto);
            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateUser([FromBody] UserDTO userDto, Guid id)
        {
            if (userDto == null)
            {
                return BadRequest();
            }

            var resultDto = await _userRepository.UpdateAsync(userDto, id);

            return Ok(resultDto);
        }

    }
}
