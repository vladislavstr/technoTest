using UsersGroupBll.Models;

namespace UsersGroupBll
{
    public interface IUserService
    {
        List<User> GetAllUsers();

        User GetUserById(int id);

        User AddUser(User user);

        void DeleteUserById(int id);
    }
}
