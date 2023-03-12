using IntelligentFormsAPI.Domain.Entities;

namespace IntelligentFormsAPI.Application.Interfaces
{
    public interface ISubmissionsService
    {
        public Task<Submission> GetSubmissionByIdAsync(Guid id);
        public Task DeleteSubmissionAsync(Guid id);
        public Task CreateSubmissionAsync(Submission submission);
    }
}
