using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntelligentFormsAPI.Application.Models
{
    public class FormTemplateDtoGet
    {
        public Guid Id { get; set; }
        public Guid UserID { get; set; }
        public string FormTitle { get; set; }
        public int DataRetentionPeriod { get; set; }
        public List<SectionDtoGet> Sections { get; set; }
    }
}
