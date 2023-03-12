using IntelligentFormsAPI.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntelligentFormsAPI.Domain.Entities
{
    public class Section
    {
        public string SectionName { get; set; } = null!;
        public string Content { get; set; } = null!;
        public ScannableDocumentType DocumentType { get; set; } 
        public  List<FormField> Fields { get; set; } = null!;
    }
}
