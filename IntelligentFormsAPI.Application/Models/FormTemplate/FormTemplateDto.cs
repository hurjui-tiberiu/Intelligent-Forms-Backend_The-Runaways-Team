using IntelligentFormsAPI.Application.Models.FormTemplate;
using IntelligentFormsAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntelligentFormsAPI.Application.Models
{
    public class FormTemplateDto
    {
        public string FormTitle { get; set; }
        public int DataRetentionPeriod { get; set; }
        public List<SectionDto> Sections { get; set; }

    }
}
