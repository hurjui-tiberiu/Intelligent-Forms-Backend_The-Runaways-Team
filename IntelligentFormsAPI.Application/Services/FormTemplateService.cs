using IntelligentFormsAPI.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IntelligentFormsAPI.Infrastructure.Interfaces;
using IntelligentFormsAPI.Domain.Entities;
using IntelligentFormsAPI.Application.Models;
using AutoMapper;

namespace IntelligentFormsAPI.Application.Services
{
    public class FormTemplateService : IFormTemplateService
    {
        private readonly IFormTemplateRepository formRepository;
        private readonly IMapper mapper;
       public FormTemplateService(IFormTemplateRepository formRepository, IMapper mapper)
        {
            this.formRepository = formRepository;
            this.mapper = mapper;
        }

        public async Task<FormTemplate> AddForm(FormTemplateDto formDto)
        {
            var form = mapper.Map<FormTemplate>(formDto);
            
          var savedForm = await formRepository.CreateForm(form);

            return savedForm;
        }

        public async Task DeleteForm(Guid Id)
        {
            await formRepository.DeleteForm(Id);
        }

        public async Task<FormTemplateDto> GetForm(Guid Id)
        {
            return mapper.Map<FormTemplateDto>(await formRepository.GetForm(Id));
        }

        public async Task UpdateForm(Guid Id, FormTemplateDto formDto)
        {
            //TO DO verificam formDto.UserId
            var form = mapper.Map<FormTemplate>(formDto);
            
        }
    }
}
