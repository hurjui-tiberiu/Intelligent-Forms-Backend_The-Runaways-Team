using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntelligentFormsAPI.Domain.Entities
{
    public record FormTemplate
    {
       public Guid Id { get; set; }
       public Guid UserID { get; set; }
       public string FormTitle { get; set; }
       public int DataRetentionPeriod { get; set; }
       public List<Section> Sections { get; set; }

    }
}
