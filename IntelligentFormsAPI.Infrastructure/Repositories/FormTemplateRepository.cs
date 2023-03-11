using IntelligentFormsAPI.Domain.Entities;
using IntelligentFormsAPI.Infrastructure.Contexts;
using IntelligentFormsAPI.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntelligentFormsAPI.Infrastructure.Repositories
{
    public class FormTemplateRepository : IFormTemplateRepository
    {

        private readonly EFContext efContext;

        public  FormTemplateRepository(EFContext efContext)
        {
            this.efContext = efContext;
        }

        public async Task<FormTemplate> CreateForm(FormTemplate form)
        {
            efContext.FormTemplates.Add(form);
            await efContext.SaveChangesAsync();

            return form;
        }

        public async Task DeleteForm(Guid Id)
        {
            throw new NotImplementedException();
        }

        public async Task<FormTemplate> GetForm(Guid Id)
        {
            throw new NotImplementedException();
        }

        public async Task<FormTemplate> UpdateForm(FormTemplate form)
        {
            throw new NotImplementedException();
        }
    }
}
