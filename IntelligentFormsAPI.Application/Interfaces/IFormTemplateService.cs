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
    public interface IFormTemplateService
    {
        public Task<FormTemplate> AddForm(FormTemplateDto form, Guid userId);
        public Task<FormTemplate?> GetForm(Guid Id);
        public Task<List<FormTemplate>?> GetFormsByUserIdAsync(Guid userID);
        public Task UpdateForm(Guid Id, FormTemplateDto form);
        public Task DeleteForm(Guid Id);
    }
}
