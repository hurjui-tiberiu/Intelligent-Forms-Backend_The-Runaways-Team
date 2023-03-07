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
        public Guid UserID { get; set; }
        public string FormTitle { get; set; }
        public int DataRetentionPeriod { get; set; }
        public List<SectionDto> Sections { get; set; }

    }
}
