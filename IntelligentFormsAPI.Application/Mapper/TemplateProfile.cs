using AutoMapper;
using IntelligentFormsAPI.Application.Models;
using IntelligentFormsAPI.Application.Models.FormTemplate;
using IntelligentFormsAPI.Domain.Entities;
using IntelligentFormsAPI.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntelligentFormsAPI.Application.Mapper
{
    public class TemplateProfile:Profile
    {
        public TemplateProfile()
        {
            CreateMap<FormTemplateDto, FormTemplate>();

            CreateMap<SectionDto, Section>()
                .ForMember(dest => dest.DocumentType,
                opt => opt.MapFrom(
                    src => Enum.Parse<ScannableDocumentType>(src.DocumentType)));

        }
    }
}
