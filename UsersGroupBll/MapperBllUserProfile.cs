using AutoMapper;
using UsersGroupBll.Models;
using UsersGroupDal.Models;

namespace UsersGroupBll
{
    public class MapperBllUserProfile : Profile
    {
        public MapperBllUserProfile()
        {
            CreateMap<UserEntity, User>().ReverseMap();
            CreateMap<UserGroupEntity, UserGroup>();
            CreateMap<UserStateEntity, UserState>();
        }
    }
}
