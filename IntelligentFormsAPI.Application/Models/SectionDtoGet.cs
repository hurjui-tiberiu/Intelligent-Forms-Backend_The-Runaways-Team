using IntelligentFormsAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntelligentFormsAPI.Application.Models
{
    public class SectionDtoGet
    {
        public List<TemplateField> Fields { get; set; }
        public string Content { get; set; }
        public string SectionName { get; set; }
        public string DocumentType { get; set; }
    }
}
