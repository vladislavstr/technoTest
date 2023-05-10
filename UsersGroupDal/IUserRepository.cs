using UsersGroupDal.Models;

namespace UsersGroupDal
{
    public interface IUserRepository
    {
        Task<List<UserEntity>> GetAllUsers();

        Task<UserEntity> GetUserById(int id);

        UserEntity AddUser(UserEntity user);

        void DeleteUserById(int id);

        Task<bool> CheckAdminAsync();
    }
}
