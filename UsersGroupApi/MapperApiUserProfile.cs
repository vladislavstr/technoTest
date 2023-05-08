using AutoMapper;
using UsersGroupApi;
using UsersGroupApi.Models;
using UsersGroupDal;
using UsersGroupDal.Models;

namespace UsersGroupApi
{
    public class MapperApiUserProfile : Profile
    {
        public MapperApiUserProfile()
        {
            CreateMap<userDto, userEntity>();
            CreateMap<userEntity, userDto>();
        }
    }
}
