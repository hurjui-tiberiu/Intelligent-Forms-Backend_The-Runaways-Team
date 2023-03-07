using IntelligentFormsAPI.Domain.Entities;
using IntelligentFormsAPI.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntelligentFormsAPI.Application.Models
{
    public class SectionDto
    {
        public List<TemplateFieldDto> Fields { get; set; }
        public string Content { get; set; }
        public string Nume { get; set; }
        public ScannableDocumentType DocumentType { get; set; }
    }
}
