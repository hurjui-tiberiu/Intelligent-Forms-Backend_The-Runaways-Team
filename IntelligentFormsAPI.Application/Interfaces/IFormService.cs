using IntelligentFormsAPI.Application.Models;
using IntelligentFormsAPI.Application.Models.FormTemplate;
using IntelligentFormsAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntelligentFormsAPI.Application.Interfaces
{
    public interface IFormService
    {
        public Task<Form> AddForm(FormDto form, Guid userId);
        public Task<Form?> GetForm(Guid Id);
        public Task<List<Form>?> GetFormsByUserIdAsync(Guid userID);
        public Task UpdateForm(Guid Id, FormDto form);
        public Task DeleteForm(Guid Id);
    }
}
