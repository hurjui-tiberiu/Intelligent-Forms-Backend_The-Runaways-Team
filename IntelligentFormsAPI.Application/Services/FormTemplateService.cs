using AutoMapper;
using IntelligentFormsAPI.Application.Interfaces;
using IntelligentFormsAPI.Application.Models;
using IntelligentFormsAPI.Application.Models.FormTemplate;
using IntelligentFormsAPI.Domain.Entities;
using IntelligentFormsAPI.Infrastructure.Interfaces;
using System.Text.Json.Nodes;

namespace IntelligentFormsAPI.Application.Services
{
    public class FormTemplateService : IFormTemplateService
    {
        private readonly IFormTemplateRepository formRepository;
        private readonly IMapper mapper;
        private readonly IUserRepository userRepository;
        
        public FormTemplateService(IFormTemplateRepository formRepository, IMapper mapper,
        IUserRepository userRepository)
        {
            this.formRepository = formRepository;
            this.mapper = mapper;
            this.userRepository = userRepository;
        }

        public async Task<FormTemplate> AddForm(FormTemplateDto formDto, Guid userId)
        {
            var user = await userRepository.GetUserById(userId);
            
            if(user is null)
                throw new ArgumentException("User not found");

            var form = mapper.Map<FormTemplate>(formDto);
            form.UserId = userId;

            var savedForm = await formRepository.CreateForm(form);

            return savedForm;
        }
        
        public async Task<List<FormTemplate>?> GetFormsByUserIdAsync(Guid userID)
        {
            var forms = await formRepository.GetFormsByUserId(userID);
            
            return forms;
        }

        public async Task DeleteForm(Guid Id)
        {
            var form = await formRepository.GetFormByIdAsync(Id);
            
            await formRepository.DeleteFormByIdAsync(form);
        }

        public async Task<FormTemplate?> GetForm(Guid Id)
        {
            return await formRepository.GetFormByIdAsync(Id);
        }
        
        public async Task UpdateForm(Guid Id, FormTemplateDto formDto)
        {

            var form = await formRepository.GetFormByIdAsync(Id);

            if (form is null)
                throw new ArgumentException("Form does not exist");

            mapper.Map(formDto, form);

            await formRepository.UpdateForm(form);

        }
    }
}
