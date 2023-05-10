using UsersGroupBll.Models;

namespace UsersGroupBll
{
    public interface IUserService
    {
        Task<List<User>> GetAllUsers();

        Task<User> GetUserById(int id);

        Task<User> AddUser(User user);

        void DeleteUserById(int id);
    }
}
