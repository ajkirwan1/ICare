using ICare.Application.Interfaces;
using ICare.Domain;
using Microsoft.EntityFrameworkCore;

namespace ICare.Persistence.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly DataContext _dataContext;

        public UserRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
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

        public async Task<IEnumerable<User>> GetAllAsync()
        {
            return _dataContext.Users.ToList();
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
