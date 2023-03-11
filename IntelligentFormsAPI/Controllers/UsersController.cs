using FluentValidation;
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
        private readonly IValidator<UserSignUpDto> userValidator;

        public UsersController(IUserService userService, ILogger<UsersController> logger,
            IValidator<UserSignUpDto> userValidator)
        {
            this.userService = userService;
            this.logger = logger;
            this.userValidator = userValidator;
        }

        [HttpPost, Route("SignUp")]
        public async Task<IActionResult> SignUp(UserSignUpDto userSignUpDto)
        {
            try
            {
                var result = await userValidator.ValidateAsync(userSignUpDto);

                if (!result.IsValid)
                    return BadRequest(result.ToString());

                await userService.SignUpAsync(userSignUpDto);
                
                return Ok();
            }
            catch (Exception ex)
            {
                logger.LogError(ex.Message);
                
                return BadRequest(ex.Message);
            }

        }

        [HttpPost, Route("SignIn")]
        public async Task<IActionResult> SignIn(UserSignInDto signInDto)
        {
            try
            {
                var user = await userService.SignInAsync(signInDto);

                return Ok(user);
            }
            catch (Exception ex)
            {
                logger.LogError(ex.Message);
                
                return BadRequest(ex.Message);
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
