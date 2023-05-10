using AutoMapper;
using UsersGroupBll.Models;
using UsersGroupDal;
using UsersGroupDal.Models;

namespace UsersGroupBll
{
    public class UserService : IUserService
    {
        private readonly IMapper _mapper;
        private readonly IUserRepository _userRepository;

        public UserService(IMapper mapper, IUserRepository userRepository)
        {
            _mapper = mapper;
            _userRepository = userRepository;
        }
        public async Task<List<User>> GetAllUsers()
        {

            var usersEntity = await _userRepository.GetAllUsers();
            var result = _mapper.Map<List<User>>(usersEntity);

            return result;
        }

        public async Task<User> GetUserById(int id)
        {
            UserEntity userEntity = await _userRepository.GetUserById(id);

            var result = _mapper.Map<User>(userEntity);

            return result;
        }

        public async Task<User> AddUser(User user)
        {
            if (!await _userRepository.CheckAdminAsync() || user.UserGroupId == 2)
            {

                var userEntity = _mapper.Map<UserEntity>(user);
                var callback = await _userRepository.AddUser(userEntity);
                var result = _mapper.Map<User>(callback);

                return result;
            }
            else
            {
                throw new Exception($"Админимтратор уже существует");
            }

        }
        public async void DeleteUserById(int id)
        {
            var existUser = await _userRepository.GetUserById(id);
            if (existUser is null)
            {
                throw new Exception($"Пользователя с id:{id} не существует");
            }

            _userRepository.DeleteUserById(id);
        }
    }
}
