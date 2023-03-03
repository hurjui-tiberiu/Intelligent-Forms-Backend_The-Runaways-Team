using IntelligentFormsAPI.Application.Interfaces;
using IntelligentFormsAPI.Application.Models;
using IntelligentFormsAPI.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace IntelligentFormsAPI.Controllers
{
    [Route("api/v1/[controller]"), ApiController]
    public class UsersController : ControllerBase
    {
        private readonly ILogger<UsersController> logger;
        private readonly IUserService userService;

        public UsersController(IUserService userService, ILogger<UsersController> logger)
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
        public async Task<ActionResult<User>> GetUser()
        {
            return Ok(new User {
                Id = Guid.NewGuid(),
                Name = "John Doe",
                Address = "1234 Main St",
                EmailAddress = "johndoe@gmail.com",
            });
          
        }

        [HttpPost, Route("ForgotPassword")]
        public Task<IActionResult> ForgotPassword(string forgotPassword)
        {
            throw new NotImplementedException();
        }

        [HttpPost, Route("ResetPassword")]
        public Task<IActionResult> ResetPassword(string resetPassword)
        {
            throw new NotImplementedException();
        }
    }
}
