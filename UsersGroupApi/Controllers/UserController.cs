﻿using AutoMapper;
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
    }
}
