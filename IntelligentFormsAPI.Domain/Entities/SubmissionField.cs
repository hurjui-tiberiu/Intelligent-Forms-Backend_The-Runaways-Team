﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntelligentFormsAPI.Domain.Entities
{
    public record SubmissionField
    {
        public string Label { get; set; } = null!;
        public string Value { get; set; } = null!;
    }
}
