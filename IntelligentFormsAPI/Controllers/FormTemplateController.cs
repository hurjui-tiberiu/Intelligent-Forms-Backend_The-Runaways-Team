using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using IntelligentFormsAPI.Application.Interfaces;
using IntelligentFormsAPI.Application.Models.FormTemplate;
using IntelligentFormsAPI.Application.Models;

namespace IntelligentFormsAPI.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class FormTemplateController : ControllerBase
    {
        private readonly IFormTemplateService formService;
        private readonly ILogger<FormTemplateController> logger;

        public FormTemplateController(IFormTemplateService formService, ILogger<FormTemplateController> logger)
        {
            this.formService = formService;
            this.logger = logger;
        }  
        
        [HttpGet("{id}")]
        public async Task<ActionResult<FormTemplateDto>> GetFormTemplateById(Guid id)
        {
            try
            {
                var form = await formService.GetForm(id);
                return  Ok(form);
            }
            catch (Exception ex)
            {
                logger.LogError(ex.Message);

                return BadRequest(ex.Message);
            }
        }


        [HttpGet]
        public async Task<ActionResult<List<FormTemplateDto>>> GetFormTemplatesByUserId([FromQuery] Guid userid)
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

        [HttpPost]
        public async Task<ActionResult> AddFormTemplate(FormTemplateDto formDto, [FromQuery] Guid userId)
        {
            try
            {
               var form=  await formService.AddForm(formDto, userId);
                return Ok(form);
            }
            catch (Exception ex)
            {
                logger.LogError(ex.Message);

                return BadRequest(ex.Message);
            }
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateFormTemplate([FromBody]FormTemplateDto formDto, Guid id)
        {
            try
            {
                await formService.UpdateForm(id,formDto);
                return Ok();
            }
            catch (Exception ex)
            {
                logger.LogError(ex.Message);

                return BadRequest(ex.Message);
            }
        }
        
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteFormTemplate(Guid id)
        {
            try
            {
                await formService.DeleteForm(id);
                return Ok();
            }
            catch (Exception ex)
            {
                logger.LogError(ex.Message);

                return BadRequest();
            }
        }


    }
}
