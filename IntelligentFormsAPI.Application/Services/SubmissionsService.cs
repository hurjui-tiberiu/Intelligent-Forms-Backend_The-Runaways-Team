using IntelligentFormsAPI.Application.Interfaces;
using IntelligentFormsAPI.Domain.Entities;
using IntelligentFormsAPI.Infrastructure.Interfaces;

namespace IntelligentFormsAPI.Application.Services
{
    public class SubmissionsService : ISubmissionsService
    {
        private readonly ISubmissionsRepository _submissionRepository;
        private readonly IUsersRepository _userRepository;

        public SubmissionsService(ISubmissionsRepository submissionRepository, IUsersRepository userRepository)
        {
            _submissionRepository = submissionRepository;
            _userRepository = userRepository;
        }

        public async Task<Submission> GetSubmissionByIdAsync(Guid id)
        {
            return await _submissionRepository.GetSubmissionByIdAsync(id);
        }

        public async Task DeleteSubmissionAsync(Guid id)
        {
            await _submissionRepository.DeleteSubmissionAsync(id);
        }

        public async Task CreateSubmissionAsync(Submission submission)
        {
            await _submissionRepository.CreateSubmissionAsync(submission);
        }

    }
}

