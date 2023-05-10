using UsersGroupDal.Models;

namespace UsersGroupDal
{
    public interface IUserRepository
    {
        Task<List<UserEntity>> GetAllUsers();

        Task<UserEntity> GetUserById(int id);

        Task<UserEntity> AddUser(UserEntity user);

        void DeleteUserById(int id);

        Task<bool> CheckAdminAsync();
    }
}
