using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using UsersGroupApi.Models.Request;
using UsersGroupApi.Models.Response;
using UsersGroupBll;
using UsersGroupBll.Models;

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
        public async Task<ActionResult<List<UserResponseDto>>> GetAllUsers()
        {
            var allUsers = await _userService.GetAllUsers();
            var allUsersResponseDto = _mapper.Map<List<UserResponseDto>>(allUsers);
            return Ok(allUsersResponseDto);
        }

        [HttpGet("{id:int}", Name = "GetUserById")]
        public async Task<ActionResult<UserResponseDto>> GetUserById(int id)
        {

            var user = await _userService.GetUserById(id);
            var userResponse = _mapper.Map<UserResponseDto>(user);
            return Ok(userResponse);
        }

        [HttpDelete("{id:int}", Name = "DeleteUserById")]
        public async Task<IActionResult> DeleteUserById(int id)
        {
            _userService.DeleteUserById(id);
            return NoContent();
        }

        [HttpPost(Name = "AddUser")]
        public async Task<ActionResult<UserResponseDto>> AddUser(UserRequestDto userReques)
        {
            try
            {

                var user = _mapper.Map<User>(userReques);
                user.CreatedDate = DateTime.UtcNow;
                user.UserStateId = 1;

                var addUserResponse = await _userService.AddUser(user);
                var addUserResponseDto = _mapper.Map<UserResponseDto>(addUserResponse);

                return addUserResponseDto;
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
