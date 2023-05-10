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
            CreateMap<UserRequestDto, User>();
            //CreateMap<User, UserRequestDto>();
            CreateMap<User, UserResponseDto>();
            //CreateMap<UserResponseDto, User>();
        }
    }
}
