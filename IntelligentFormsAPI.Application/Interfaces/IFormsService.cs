using IntelligentFormsAPI.Application.Models;
using IntelligentFormsAPI.Domain.Entities;

namespace IntelligentFormsAPI.Application.Interfaces
{
    public interface IFormsService
    {
        public Task<Form> AddForm(FormDto form, Guid userId);
        public Task<Form?> GetForm(Guid Id);
        public Task<List<Form>?> GetFormsByUserIdAsync(Guid userID);
        public Task UpdateForm(Guid Id, FormDto form);
        public Task DeleteForm(Guid Id);
    }
}
