using IntelligentFormsAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntelligentFormsAPI.Application.Models.Submission
{
    public class SubmissionDto
    {
        public List<SubmissionField> SubmissionFields { get; set; } = null!;
        public string Content { get; set; } = null!;
    }
}
