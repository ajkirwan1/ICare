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
        private readonly IMapper mapper;

        public UserRepository(DataContext dataContext, IMapper mapper)
        {
            _dataContext = dataContext;
            this.mapper = mapper;
        }
        public async Task<User> AddAsync(User entity)
        {
            await _dataContext.Users.AddAsync(entity);
            await _dataContext.SaveChangesAsync();

            return entity;
        }

        public Task<User> DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<UserDTO>> GetAllAsync()
        {
            var users = _dataContext.Users.ToList();
            var userDto = mapper.Map<IEnumerable<UserDTO>>(users);
            return userDto;
        }

        public async Task<User?> GetByIdAsync(Guid id)
        {
            var result = await _dataContext.Users.FirstOrDefaultAsync(user => user.Id == id);
            return result;
        }

        public async Task<User> UpdateAsync(User entity)
        {
            await _dataContext.Users.AddAsync(entity);
            await _dataContext.SaveChangesAsync();

            return entity;
        }
    }
}
