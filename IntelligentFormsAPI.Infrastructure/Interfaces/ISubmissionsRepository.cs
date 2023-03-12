using IntelligentFormsAPI.Domain.Entities;

namespace IntelligentFormsAPI.Infrastructure.Interfaces
{
    public interface ISubmissionsRepository
    {
        public Task<Submission> GetSubmissionByIdAsync(Guid id);
        public Task DeleteSubmissionAsync(Guid id);
        public Task CreateSubmissionAsync(Submission submission);
    }
}
