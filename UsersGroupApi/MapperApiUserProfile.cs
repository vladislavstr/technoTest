using AutoMapper;
using UsersGroupApi.Models.Request;
using UsersGroupApi.Models.Response;
using UsersGroupBll.Models;

namespace UsersGroupApi
{
    public class MapperApiUserProfile : Profile
    {
        public MapperApiUserProfile()
        {
            CreateMap<UserRequestDto, User>();
            CreateMap<User, UserResponseDto>();
        }
    }
}
