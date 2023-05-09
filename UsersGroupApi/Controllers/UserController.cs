using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using UsersGroupApi.Models;
using UsersGroupDal;
using UsersGroupDal.Models;

namespace UsersGroupApi.Controllers
{
    [Route("api/[controller]")]
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

        [HttpGet("AllUsers", Name = "GetAllUsers")]
        public ActionResult<List<userDto>> GetAllUsers()
        {
                var allUsers = _userService.GetAllUsers();
                var allUsersDto = _mapper.Map<List<userEntity>>(allUsers);
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

        [HttpPost("AddUser", Name = "AddUser")]
        public ActionResult<userDto> AddUser(userDto user)
        {
            user.created_date = DateTime.UtcNow;
            var userRequst = _mapper.Map<userEntity>(user);
            var addUserResponse = _userService.AddUser(userRequst);
            var addUserResponseDto = _mapper.Map<userDto>(addUserResponse);

            return Created(new Uri("api/User", UriKind.Relative), addUserResponseDto);
        }
    }
}
