using IntelligentFormsAPI.Application.Interfaces;
using IntelligentFormsAPI.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace IntelligentFormsAPI.Controllers
{
    [Route("api/v1/"), ApiController]
    public class SubmissionController : ControllerBase
    {
        private readonly ILogger<SubmissionController> logger;
        private readonly ISubmissionsService submissionService;

        public SubmissionController(ILogger<SubmissionController> logger, ISubmissionsService submissionService)
        {
            this.logger = logger;
            this.submissionService = submissionService;
        }

        [HttpPost, Route("Users/{userId}/FormTemplates/{formTemplateId}/Submissions/{submissionId}")]
        public async Task<IActionResult> CreateSubmission(Submission submission)
        {
            try
            {
                await submissionService.CreateSubmissionAsync(submission);

                return Ok();
            }
            catch (Exception ex)
            {
                logger.LogError(ex.Message);

                return BadRequest();
            }
        }

        [HttpGet, Route("Submissions/{submissionId}")]
        public async Task<IActionResult> GetSubmissionById(Guid submissionId)
        {
            try
            {
                var submission = await submissionService.GetSubmissionByIdAsync(submissionId);

                return Ok(submission);
            }
            catch (Exception ex)
            {
                logger.LogError(ex.Message);

                return BadRequest();
            }
        }

        [HttpDelete, Route("Submissions/{submissionId}")]
        public async Task<IActionResult> DeleteSubmission(Guid submissionId)
        {
            try
            {
                await submissionService.DeleteSubmissionAsync(submissionId);

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
