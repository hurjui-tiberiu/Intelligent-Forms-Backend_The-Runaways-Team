using IntelligentFormsAPI.Domain.Entities;

namespace IntelligentFormsAPI.Infrastructure.Interfaces
{
    public interface IFormRepository
    {
        public Task<Form> CreateForm(Form form);
        public Task<Form?> GetFormByIdAsync(Guid Id);
        public Task<List<Form>?> GetFormsByUserId(Guid userId);
        public Task<Form> UpdateForm(Form form);
        public Task DeleteFormByIdAsync(Form formTemplate);

    }
}
