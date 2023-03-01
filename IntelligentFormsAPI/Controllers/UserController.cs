using IntelligentFormsAPI.Application.Interfaces;
using IntelligentFormsAPI.Application.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Cosmos;

namespace IntelligentFormsAPI.Controllers
{
    [Route("api/v1/[controller]"), ApiController]
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> logger;
        private readonly IUserService userService;

        public UserController(IUserService userService, ILogger<UserController> logger)
        {
            this.userService = userService;
            this.logger = logger;
        }

        [HttpPost, Route("SignUp")]
        public Task<IActionResult> CreateAccount(UserSignUpDto createUserDto)
        {
            throw new NotImplementedException();
        }

        [HttpPost, Route("SignIn")]
        public Task<IActionResult> SignIn(UserSignInDto signInDto)
        {
            throw new NotImplementedException();
        }

        [HttpPatch, Route("{id}")]
        public Task<IActionResult> UpdateUser(Guid id, dynamic updateUserDto)
        {
            throw new NotImplementedException();
        }

        [HttpPost, Route("LogOut")]
        public Task<IActionResult> LogOut()
        {
            throw new NotImplementedException();
        }

        [HttpGet, Route("{id}")]
        public Task<IActionResult> GetUser(Guid id)
        {
            throw new NotImplementedException();
        }

        [HttpPost, Route("forgotPassword")]
        public Task<IActionResult> ForgotPassword(string forgotPassword)
        {
            throw new NotImplementedException();
        }

        [HttpPost, Route("resetPassword")]
        public Task<IActionResult> ResetPassword(string resetPassword)
        {
            throw new NotImplementedException();
        }
    }
}
