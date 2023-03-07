using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntelligentFormsAPI.Application.Models
{
    public class TemplateFieldDto
    {
        public string Label { get; set; }
        public string PlaceHolder_Key { get; set; }
        public bool Mandatory { get; set; }
        public string FieldType { get; set; }
        public List<string> Document_KeyWords { get; set; }
        public List<string>? Options { get; set; }  //in functie de FieldType
    }
}
