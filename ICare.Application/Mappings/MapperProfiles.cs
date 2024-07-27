using AutoMapper;
using ICare.Application.DTOs;
using ICare.Domain;

namespace ICare.Application.Mappings
{
    public class MapperProfiles : Profile
    {
        public MapperProfiles()
        {
            CreateMap<User, UserDTO>().ReverseMap();
        }
    }
}
