using AutoMapper;
using IntelligentFormsAPI.Application.Interfaces;
using IntelligentFormsAPI.Application.Models;
using IntelligentFormsAPI.Application.Models.Form;
using IntelligentFormsAPI.Domain.Entities;
using IntelligentFormsAPI.Infrastructure.Interfaces;

namespace IntelligentFormsAPI.Application.Services
{
    public class FormsService : IFormsService
    {
        private readonly IFormsRepository formRepository;
        private readonly IMapper mapper;
        private readonly IUsersRepository userRepository;

        public FormsService(IFormsRepository formRepository, IMapper mapper,
        IUsersRepository userRepository)
        {
            this.formRepository = formRepository;
            this.mapper = mapper;
            this.userRepository = userRepository;
        }

        public async Task<FormCreateResponseDto?> AddForm(FormDto formDto, Guid userId)
        {
            var user = await userRepository.GetUserById(userId);

            if (user is null)
                throw new ArgumentException("User not found");

            var form = mapper.Map<Form>(formDto);
            form.UserId = userId;

            var savedForm = await formRepository.CreateForm(form);

            return mapper.Map<FormCreateResponseDto>(savedForm);
        }
        
        public async Task<List<FormCreateResponseDto>?> GetFormsByUserIdAsync(Guid userID)
        {
            var forms = await formRepository.GetFormsByUserId(userID);

            return mapper.Map<List<FormCreateResponseDto>>(forms);
        }

        public async Task DeleteForm(Guid Id)
        {
            var form = await formRepository.GetFormByIdAsync(Id);

            await formRepository.DeleteFormByIdAsync(form);
        }
        public async Task UpdateForm(Guid Id, FormDto formDto)
        {

            var form = await formRepository.GetFormByIdAsync(Id);

            if (form is null)
                throw new ArgumentException("Form does not exist");

            mapper.Map(formDto, form);

            await formRepository.UpdateForm(form);

        }

        public async Task<FormCreateResponseDto?> GetForm(Guid Id)
        {
            var form = await formRepository.GetFormByIdAsync(Id);

            return mapper.Map<FormCreateResponseDto>(form);
        }

    }
}
