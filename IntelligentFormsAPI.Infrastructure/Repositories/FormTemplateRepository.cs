using IntelligentFormsAPI.Domain.Entities;
using IntelligentFormsAPI.Infrastructure.Contexts;
using IntelligentFormsAPI.Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;
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

        public async Task DeleteFormByIdAsync(FormTemplate formTemplate)
        {
            efContext.FormTemplates.Remove(formTemplate);
            
            await efContext.SaveChangesAsync();
        }

        public async Task<FormTemplate?> GetFormByIdAsync(Guid Id)
        {
            var form = await efContext.FormTemplates.FindAsync(Id);

            return form;
        }

        public async Task<List<FormTemplate>?> GetFormsByUserId(Guid userId)
        {
            var forms = await efContext.FormTemplates.Where(x => x.UserId == userId).ToListAsync();

            return forms;
        }

        public async Task<FormTemplate> UpdateForm(FormTemplate form)
        {
            efContext.FormTemplates.Update(form);
            await efContext.SaveChangesAsync();

            return form;
        }

        
    }
}
