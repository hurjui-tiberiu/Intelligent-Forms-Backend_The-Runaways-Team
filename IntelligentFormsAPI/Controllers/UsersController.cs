using IntelligentFormsAPI.Application.Interfaces;
using IntelligentFormsAPI.Application.Models;
using IntelligentFormsAPI.Infrastructure.Contexts;
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
        public async Task<IActionResult> SignUp(UserSignUpDto userSignUpDto)
        {
            try
            {
                await userService.SignUpAsync(userSignUpDto);
                
                return Ok();
            }
            catch (Exception ex)
            {
                logger.LogError(ex.Message);
                
                return BadRequest();
            }

        }

        [HttpPost, Route("SignIn")]
        public async Task<IActionResult> SignIn(UserSignInDto signInDto)
        {
            try
            {
                var user = await userService.GetUserByEmailAsync(signInDto.EmailAddress);

                if (user is null)
                    return BadRequest();

                if (signInDto.Password.Equals(user.Password))
                    return Ok(); 
                else return BadRequest();
            }
            catch (Exception ex)
            {
                logger.LogError(ex.Message);
                
                return BadRequest();
            }
        }

        [HttpPatch, Route("{id}")]
        public async Task<IActionResult> UpdateUser(Guid id, dynamic patchUserDto)
        {
            try
            {
                await userService.UpdateUserAsync(id, patchUserDto);

                return Ok();
            }
            catch (Exception ex)
            {
                logger.LogError(ex.Message);
                
                return BadRequest();
            }

        }

        [HttpGet, Route("{id}")]
        public async Task<ActionResult<UserDto>> GetUserById(Guid id)
        {
            try
            {
                var userDto = await userService.GetUserById(id);
                
                return userDto;
            }
            catch (Exception ex)
            {
                logger.LogError(ex.Message);
                
                return BadRequest();
            }
        }
    }
}
