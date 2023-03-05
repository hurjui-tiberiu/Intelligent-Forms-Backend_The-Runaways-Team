using IntelligentFormsAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntelligentFormsAPI.Application.Interfaces
{
    public interface ISubmissionService
    {
        public Task<Submission> GetSubmissionByIdAsync(Guid id);
        public Task DeleteSubmissionAsync(Guid id);
        public Task CreateSubmissionAsync(Submission submission);
    }
}
