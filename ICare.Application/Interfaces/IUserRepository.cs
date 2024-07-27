using ICare.Application.DTOs;
using ICare.Domain;

namespace ICare.Application.Interfaces
{
    public interface IUserRepository : IRepository<User, UserDTO>
    {
    }
}
