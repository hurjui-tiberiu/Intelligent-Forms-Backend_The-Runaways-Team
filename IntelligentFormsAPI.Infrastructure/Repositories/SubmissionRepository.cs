using IntelligentFormsAPI.Domain.Entities;
using IntelligentFormsAPI.Infrastructure.Contexts;
using IntelligentFormsAPI.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntelligentFormsAPI.Infrastructure.Repositories
{
    public class SubmissionRepository : ISubmissionRepository
    {
        private readonly EFContext eFContext;

        public SubmissionRepository(EFContext eFContext)
        {
            this.eFContext = eFContext;
        }

        public async Task CreateSubmissionAsync(Submission submission)
        {
            await eFContext.Submissions.AddAsync(submission);
            await eFContext.SaveChangesAsync();
        }

        public async Task DeleteSubmissionAsync(Guid id)
        {
            var submission = await eFContext.Submissions.FindAsync(id);
            
            if(submission is not null)
                 eFContext.Submissions.Remove(submission);
            await eFContext.SaveChangesAsync();
        }


        public async Task<Submission> GetSubmissionByIdAsync(Guid id)
        {
            return await eFContext.Submissions.FindAsync(id);
        }

    }
}
