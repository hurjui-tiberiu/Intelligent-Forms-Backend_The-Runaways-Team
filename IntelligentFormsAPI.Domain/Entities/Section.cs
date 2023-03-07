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
        public List<Guid> FieldsId { get; set; }
        public string Content { get; set; }
        public string Name { get; set; }
        public ScannableDocumentType DocumentType { get; set; }
    }
}
