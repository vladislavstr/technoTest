using UsersGroupBll.Models;
using UsersGroupDal.Models;
using UsersGroupDal;
using AutoMapper;

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
        public List<User> GetAllUsers()
        {

            var usersEntity =  _userRepository.GetAllUsers();
            var result = _mapper.Map<List<User>>(usersEntity);

            return result;
        }

        public User GetUserById(int id)
        {
            UserEntity userEntity =  _userRepository.GetUserById(id);

            var result = _mapper.Map<User>(userEntity);

            return result;
        }

        public User AddUser(User user)
        {
            var userEntity = _mapper.Map<UserEntity>(user);
            var callback = _userRepository.AddUser(userEntity);
            var result = _mapper.Map<User>(callback);

            return result;

        }
        public void DeleteUserById(int id)
        {
            var existUser =  _userRepository.GetUserById(id);
            if (existUser is null)
            {
                throw new Exception($"Пользователя с id:{id} не существует");
            }

            _userRepository.DeleteUserById(id);

        }
    }
}
