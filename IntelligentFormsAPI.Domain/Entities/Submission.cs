using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntelligentFormsAPI.Domain.Entities
{
    public record Submission
    {
        public Guid Id { get; set; }
        public List<SubmissionField> Fields { get; set; }
        public List<string> Sections { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}
