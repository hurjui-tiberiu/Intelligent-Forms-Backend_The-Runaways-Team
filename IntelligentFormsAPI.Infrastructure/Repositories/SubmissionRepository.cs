using IntelligentFormsAPI.Domain.Entities;
using IntelligentFormsAPI.Infrastructure.Contexts;
using IntelligentFormsAPI.Infrastructure.Interfaces;

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

            if (submission is not null)
                eFContext.Submissions.Remove(submission);
            await eFContext.SaveChangesAsync();
        }


        public async Task<Submission> GetSubmissionByIdAsync(Guid id)
        {
            return await eFContext.Submissions.FindAsync(id);
        }

    }
}
