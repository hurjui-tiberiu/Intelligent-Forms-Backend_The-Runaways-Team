using AutoMapper;
using IntelligentFormsAPI.Application.Models;
using IntelligentFormsAPI.Application.Models.FormTemplate;
using IntelligentFormsAPI.Domain.Entities;
using IntelligentFormsAPI.Domain.Enums;

namespace IntelligentFormsAPI.Application.Mapper
{
    public class TemplateProfile : Profile
    {
        public TemplateProfile()
        {
            CreateMap<FormDto, Form>();

            CreateMap<SectionDto, Section>()
                .ForMember(dest => dest.DocumentType,
                opt => opt.MapFrom(
                    src => Enum.Parse<ScannableDocumentType>(src.DocumentType)));

        }
    }
}
