using UsersGroupDal.Models;
using Microsoft.EntityFrameworkCore;

namespace UsersGroupDal
{
    public class UserRepository : IUserService
    {
        private static UserContext _context;

        public UserRepository(UserContext context)
        {
            _context = context;
        }

        public List<userEntity> GetAllUsers()
        {

            var result = new List<userEntity>();

            result = _context.Users
                .Include(u => u.user_group)
                .Include(u => u.user_state)
                .AsNoTracking()
                .ToList();

            return result;
        }

        public userEntity GetUserById(int id)
        {
            return _context.Users
            .Include(u => u.user_group)
            .Include(u => u.user_state)
            .Single(u => u.id == id);
        }

        public void DeleteUserById(int id)
        {
                var user = _context.Users.Single(u => u.id == id);
                user.user_state_id = 2;
                _context.SaveChanges();
        }
    }
}
