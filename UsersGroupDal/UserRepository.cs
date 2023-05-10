using Microsoft.EntityFrameworkCore;
using UsersGroupDal.Models;

namespace UsersGroupDal
{
    public class UserRepository : IUserRepository
    {
        private static UserContext _context;

        public UserRepository(UserContext context)
        {
            _context = context;

            //UserGroupEntity defaultUserGroupEntity_1 = new UserGroupEntity { Code = "Admin" };
            //UserGroupEntity defaultUserGroupEntity_2 = new UserGroupEntity { Code = "User" };
            //UserStateEntity defaultUserStateEntity_1 = new UserStateEntity { Code = "Active" };
            //UserStateEntity defaultUserStateEntity_2 = new UserStateEntity { Code = "Blocked" };

            //_context.Groups.Add(defaultUserGroupEntity_1);
            //_context.Groups.Add(defaultUserGroupEntity_2);
            //_context.States.Add(defaultUserStateEntity_1);
            //_context.States.Add(defaultUserStateEntity_2);

            //_context.SaveChanges();
        }

        public async Task<List<UserEntity>> GetAllUsers()
        {
            var result = new List<UserEntity>();

            result = _context.Users
                .Include(u => u.UserGroup)
                .Include(u => u.UserState)
                .AsNoTracking()
                .ToList();

            return result;
        }

        public async Task<UserEntity> GetUserById(int id)
        {
            return _context.Users
           .Include(u => u.UserGroup)
           .Include(u => u.UserState)
           .Single(u => u.Id == id);
        }

        public async Task<UserEntity> AddUser(UserEntity user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();

            return _context.Users
                .Include(u => u.UserGroup)
                .Include(u => u.UserState)
                .Single(u => u.Id == user.Id);
        }

        public async void DeleteUserById(int id)
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
