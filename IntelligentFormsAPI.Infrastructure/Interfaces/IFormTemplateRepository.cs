using IntelligentFormsAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
