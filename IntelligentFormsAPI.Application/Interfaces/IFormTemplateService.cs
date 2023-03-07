using IntelligentFormsAPI.Application.Models;
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
        public Task AddForm(FormTemplateDto form);
        public Task<FormTemplateDto> GetForm(Guid Id);
        public Task UpdateForm(Guid Id, FormTemplateDto form);
        public Task DeleteForm(Guid Id);
    }
}
