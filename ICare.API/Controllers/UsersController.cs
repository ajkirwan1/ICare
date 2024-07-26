using AutoMapper;
using ICare.Application.Interfaces;
using ICare.Domain;
using ICare.Persistence;
using Microsoft.AspNetCore.Mvc;

namespace ICare.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly DataContext _dataContext;
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public UsersController(DataContext dataContext, IUserRepository userRepository, IMapper mapper)
        {
            _dataContext = dataContext;
            _userRepository = userRepository;
            _mapper = mapper;
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
        public async Task<IActionResult> CreateUser([FromBody] User user)
        {
            if (user == null)
            {
                return BadRequest();
            }

            await _userRepository.AddAsync(user);
            return Ok(user);
        }

    }
}
