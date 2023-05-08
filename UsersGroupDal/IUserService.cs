using UsersGroupDal.Models;

namespace UsersGroupDal
{
    public interface IUserService
    {
        List<userEntity> GetAllUsers();

        userEntity GetUserById(int id);

        void DeleteUserById(int id);
    }
}
