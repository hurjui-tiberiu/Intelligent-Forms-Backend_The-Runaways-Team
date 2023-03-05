using IntelligentFormsAPI.Application.Interfaces;
using IntelligentFormsAPI.Domain.Entities;
using IntelligentFormsAPI.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntelligentFormsAPI.Application.Services
{
    public class SubmissionService : ISubmissionService
    {
        private readonly ISubmissionRepository _submissionRepository;
        private readonly IUserRepository _userRepository;

        public SubmissionService(ISubmissionRepository submissionRepository, IUserRepository userRepository)
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

