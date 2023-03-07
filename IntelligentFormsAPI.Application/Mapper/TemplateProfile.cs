using AutoMapper;
using IntelligentFormsAPI.Application.Models;
using IntelligentFormsAPI.Domain.Entities;
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
            CreateMap<FormTemplate, FormTemplateDto>();

            CreateMap<SectionDto, Section>();   
            CreateMap<Section, SectionDto>();

            CreateMap<TemplateField, TemplateFieldDto>();
            CreateMap<TemplateFieldDto, TemplateField>();
        }
    }
}
