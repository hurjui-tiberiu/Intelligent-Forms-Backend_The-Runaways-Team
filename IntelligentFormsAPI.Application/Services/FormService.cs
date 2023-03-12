using AutoMapper;
using IntelligentFormsAPI.Application.Interfaces;
using IntelligentFormsAPI.Application.Models;
using IntelligentFormsAPI.Domain.Entities;
using IntelligentFormsAPI.Infrastructure.Interfaces;

namespace IntelligentFormsAPI.Application.Services
{
    public class FormService : IFormService
    {
        private readonly IFormRepository formRepository;
        private readonly IMapper mapper;
        private readonly IUserRepository userRepository;

        public FormService(IFormRepository formRepository, IMapper mapper,
        IUserRepository userRepository)
        {
            this.formRepository = formRepository;
            this.mapper = mapper;
            this.userRepository = userRepository;
        }

        public async Task<Form> AddForm(FormDto formDto, Guid userId)
        {
            var user = await userRepository.GetUserById(userId);

            if (user is null)
                throw new ArgumentException("User not found");

            var form = mapper.Map<Form>(formDto);
            form.UserId = userId;

            var savedForm = await formRepository.CreateForm(form);

            return savedForm;
        }

        public async Task<List<Form>?> GetFormsByUserIdAsync(Guid userID)
        {
            var forms = await formRepository.GetFormsByUserId(userID);

            return forms;
        }

        public async Task DeleteForm(Guid Id)
        {
            var form = await formRepository.GetFormByIdAsync(Id);

            await formRepository.DeleteFormByIdAsync(form);
        }

        public async Task<Form?> GetForm(Guid Id)
        {
            return await formRepository.GetFormByIdAsync(Id);
        }

        public async Task UpdateForm(Guid Id, FormDto formDto)
        {

            var form = await formRepository.GetFormByIdAsync(Id);

            if (form is null)
                throw new ArgumentException("Form does not exist");

            mapper.Map(formDto, form);

            await formRepository.UpdateForm(form);

        }
    }
}
