using UsersGroupDal.Models;

namespace UsersGroupDal
{
    public interface IUserService
    {
        List<UserEntity> GetAllUsers();

        UserEntity GetUserById(int id);

        UserEntity AddUser(UserEntity user);

        void DeleteUserById(int id);

        Task<bool> CheckAdminAsync();
    }
}
