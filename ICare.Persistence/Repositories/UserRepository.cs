using AutoMapper;
using ICare.Application.DTOs;
using ICare.Application.Interfaces;
using ICare.Domain;
using Microsoft.EntityFrameworkCore;

namespace ICare.Persistence.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly DataContext _dataContext;
        private readonly IMapper _mapper;

        public UserRepository(DataContext dataContext, IMapper mapper)
        {
            _dataContext = dataContext;
            _mapper = mapper;
        }
        public async Task<UserDTO> AddAsync(UserDTO userDTO)
        {
            var user = _mapper.Map<User>(userDTO);

            await _dataContext.Users.AddAsync(user);
            await _dataContext.SaveChangesAsync();

            return userDTO;
        }

        public Task<User> DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<UserDTO>> GetAllAsync()
        {
            var users = _dataContext.Users.ToList();
            var userDto = _mapper.Map<IEnumerable<UserDTO>>(users);
            return userDto;
        }

        public async Task<User?> GetByIdAsync(Guid id)
        {
            var result = await _dataContext.Users.FirstOrDefaultAsync(user => user.Id == id);
            return result;
        }

        public async Task<UserDTO?> UpdateAsync(UserDTO userDTO, Guid id)
        {
            var user = await _dataContext.Users.FirstOrDefaultAsync(user => user.Id == id);

            if (user == null)
            {
                return null;
            }

            user.Name = userDTO.Name;
            user.Password = userDTO.Password;

            await _dataContext.SaveChangesAsync();

            return userDTO;
        }
    }
}
