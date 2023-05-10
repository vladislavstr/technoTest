using UsersGroupDal.Models;
using Microsoft.EntityFrameworkCore;

namespace UsersGroupDal
{
    public class UserRepository : IUserRepository
    {
        private static UserContext _context;

        public UserRepository(UserContext context)
        {
            _context = context;
        }

        public List<UserEntity> GetAllUsers()
        {
            var result = new List<UserEntity>();

            result = _context.Users
                .Include(u => u.UserGroup)
                .Include(u => u.UserState)
                .AsNoTracking()
                .ToList();

            return result;
        }

        public UserEntity GetUserById(int id)
        {
            return _context.Users
            .Include(u => u.UserGroup)
            .Include(u => u.UserState)
            .Single(u => u.Id == id);
        }

        public UserEntity AddUser(UserEntity user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();

            return _context.Users
                .Include(u => u.UserGroup)
                .Include(u => u.UserState)
                .Single(u => u.Id == user.Id);
        }

        public void DeleteUserById(int id)
        {
                var user = _context.Users.Single(u => u.Id == id);
                user.UserStateId = 2;
                _context.SaveChanges();
        }

        public async Task<bool> CheckAdminAsync()
        {
            return _context.Users
                    .ToList()
                    .Any(x => x.UserGroupId == 1 && x.UserStateId == 1);
        }
    }
}
