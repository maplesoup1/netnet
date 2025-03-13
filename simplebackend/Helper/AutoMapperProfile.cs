using AutoMapper;
using simplebackend.Dtos;
using simplebackend.Entities;

namespace simplebackend.Helper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            
            CreateMap<User, UserDto>();
            CreateMap<User, UserUpdateDto>();
            CreateMap<UserUpdateDto, User>();
            CreateMap<UserCreateDto, User>();

        }
    }
}