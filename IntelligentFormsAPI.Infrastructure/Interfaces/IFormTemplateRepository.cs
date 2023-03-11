using IntelligentFormsAPI.Domain.Entities;

namespace IntelligentFormsAPI.Infrastructure.Interfaces
{
    public interface IFormTemplateRepository
    {
        public Task<FormTemplate> CreateForm(FormTemplate form);
        public Task<FormTemplate?> GetFormByIdAsync(Guid Id);
        public Task<List<FormTemplate>?> GetFormsByUserId(Guid userId);
        public Task<FormTemplate> UpdateForm(FormTemplate form);
        public Task DeleteFormByIdAsync(FormTemplate formTemplate);

    }
}
