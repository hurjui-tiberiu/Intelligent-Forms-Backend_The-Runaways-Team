using IntelligentFormsAPI.Application.Interfaces;
using IntelligentFormsAPI.Application.Models;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace IntelligentFormsAPI.Controllers
{
    [Route("api/v1/forms")]
    [ApiController]
    public class FormsController : ControllerBase
    {
        private readonly IFormService formService;
        private readonly ILogger<FormsController> logger;

        public FormsController(IFormService formService, ILogger<FormsController> logger)
        {
            this.formService = formService;
            this.logger = logger;
        }

        [SwaggerOperation(Summary = "Get a form by id")]
        [HttpGet("{id}")]
        public async Task<ActionResult<FormDto>> GetFormTemplateById(Guid id)
        {
            try
            {
                var form = await formService.GetForm(id);
                
                return Ok(form);
            }
            catch (Exception ex)
            {
                logger.LogError(ex.Message);

                return BadRequest(ex.Message);
            }
        }

        [SwaggerOperation(Summary = "Get all forms by user id")]
        [HttpGet]
        public async Task<ActionResult<List<FormDto>>> GetFormTemplatesByUserId([FromQuery] Guid userid)
        {
            try
            {
                var forms = await formService.GetFormsByUserIdAsync(userid);

                return Ok(forms);
            }
            catch (Exception ex)
            {
                logger.LogError(ex.Message);

                return BadRequest(ex.Message);
            }
        }

        [SwaggerOperation(Summary = "Create a new form")]
        [HttpPost]
        public async Task<ActionResult> AddFormTemplate(FormDto formDto, [FromQuery] Guid userId)
        {
            try
            {
                var form = await formService.AddForm(formDto, userId);
                
                return Ok(form);
            }
            catch (Exception ex)
            {
                logger.LogError(ex.Message);

                return BadRequest(ex.Message);
            }
        }

        [SwaggerOperation(Summary = "Update a form")]
        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateFormTemplate([FromBody] FormDto formDto, Guid id)
        {
            try
            {
                await formService.UpdateForm(id, formDto);
                return Ok();
            }
            catch (Exception ex)
            {
                logger.LogError(ex.Message);

                return BadRequest(ex.Message);
            }
        }

        [SwaggerOperation(Summary = "Delete a form")]
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteFormTemplate(Guid id)
        {
            try
            {
                await formService.DeleteForm(id);

                return NoContent();
            }
            catch (Exception ex)
            {
                logger.LogError(ex.Message);

                return BadRequest();
            }
        }
    }
}
