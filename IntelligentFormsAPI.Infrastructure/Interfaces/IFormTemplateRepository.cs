using IntelligentFormsAPI.Domain.Entities;

namespace IntelligentFormsAPI.Infrastructure.Interfaces
{
    public interface IFormTemplateRepository
    {
        public Task<FormTemplate> CreateForm(FormTemplate form);
        public Task<FormTemplate> GetForm(Guid Id);
        public Task<FormTemplate> UpdateForm(FormTemplate form);
        public Task DeleteForm(Guid Id);

    }
}
