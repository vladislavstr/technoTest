using AutoMapper;
using UsersGroupApi.Models.Response;
using UsersGroupApi.Models.Request;
using UsersGroupBll.Models;

namespace UsersGroupApi
{
    public class MapperApiUserProfile : Profile
    {
        public MapperApiUserProfile()
        {
            CreateMap<User, UserResponseDto>();
            CreateMap<UserRequestDto, User>();
        }
    }
}
