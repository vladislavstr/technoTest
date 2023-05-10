using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using UsersGroupApi.Models.Response;
using UsersGroupApi.Models.Request;
using UsersGroupDal;
using UsersGroupDal.Models;

namespace UsersGroupApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IUserService _userService;

        public UserController(IUserService userService, IMapper mapper)
        {

            _mapper = mapper;
            _userService = userService;
        }

        [HttpGet(Name = "GetAllUsers")]
        public ActionResult<List<UserResponseDto>> GetAllUsers()
        {
                var allUsers = _userService.GetAllUsers();
                var allUsersDto = _mapper.Map<List<UserResponseDto>>(allUsers);
                return Ok(allUsersDto);
        }

        [HttpGet("{id:int}", Name = "GetUserById")]
        public ActionResult GetUserById(int id)
        {
            return Ok(_userService.GetUserById(id));
        }

        [HttpDelete("{id:int}", Name = "DeleteUserById")]
        public IActionResult DeleteUserById(int id)
        {
            _userService.DeleteUserById(id);
            return NoContent();
        }

        [HttpPost(Name = "AddUser")]
        public ActionResult<UserResponseDto> AddUser(UserRequestDto user)
        {
            var userRequst = _mapper.Map<UserEntity>(user);
            userRequst.CreatedDate = DateTime.UtcNow;
            userRequst.UserStateId = 1;
            var addUserResponse = _userService.AddUser(userRequst);
            var addUserResponseDto = _mapper.Map<UserResponseDto>(addUserResponse);

            return Created(new Uri("api/User", UriKind.Relative), addUserResponseDto);
        }
    }
}
