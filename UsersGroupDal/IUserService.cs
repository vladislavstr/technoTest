using UsersGroupDal.Models;

namespace UsersGroupDal
{
    public interface IUserService
    {
        List<userEntity> GetAllUsers();

        userEntity GetUserById(int id);

        userEntity AddUser(userEntity user);

        void DeleteUserById(int id);
    }
}
