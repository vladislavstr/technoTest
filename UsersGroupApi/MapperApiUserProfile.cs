using AutoMapper;
using UsersGroupApi.Models.Response;
using UsersGroupApi.Models.Request;
using UsersGroupDal.Models;

namespace UsersGroupApi
{
    public class MapperApiUserProfile : Profile
    {
        public MapperApiUserProfile()
        {
            CreateMap<UserEntity, UserResponseDto>();
            CreateMap<UserRequestDto, UserEntity>();
        }
    }
}
