using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntelligentFormsAPI.Domain.Entities
{
    public class TemplateField
    {
        public string DynamicField_Key { get; set; }
        public string PlaceHolder_Key { get; set; }
        public bool Mandatory { get; set; }
        public string FieldType { get; set; }
        public List<string>? Options { get; set; }
        public string Document_KeyWords { get; set; }
    }
}
