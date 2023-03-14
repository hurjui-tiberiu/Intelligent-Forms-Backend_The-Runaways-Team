using IntelligentFormsAPI.Application.Models.Submission;
using IntelligentFormsAPI.Domain.Entities;

namespace IntelligentFormsAPI.Application.Interfaces
{
    public interface ISubmissionsService
    {
        public Task<SubmissionRequestDto> GetSubmissionByIdAsync(Guid id);
        public Task DeleteSubmissionAsync(Guid id);
        public Task<SubmissionRequestDto> CreateSubmissionAsync(SubmissionDto submissionDto, Guid formId);
        public Task<List<SubmissionRequestDto>> GetSubmissionByFormId(Guid formId);
    }
}
