
using IntelligentFormsAPI.Application.Models;
using IntelligentFormsAPI.Application.Models.Form;

namespace IntelligentFormsAPI.Application.Interfaces
{
    public interface IFormsService
    {

        public Task<FormCreateResponseDto?> AddForm(FormDto form, Guid userId);
        public Task<FormCreateResponseDto?> GetForm(Guid Id);
        public Task<List<FormCreateResponseDto>?> GetFormsByUserIdAsync(Guid userID);
        public Task UpdateForm(Guid Id, FormDto form);
        public Task DeleteForm(Guid Id);
    }
}
