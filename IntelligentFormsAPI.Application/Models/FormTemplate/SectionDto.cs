﻿using IntelligentFormsAPI.Domain.Entities;
using IntelligentFormsAPI.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntelligentFormsAPI.Application.Models.FormTemplate
{
    public class SectionDto
    {
        public string SectionName { get; set; }
        public string Content { get; set; }
        public string DocumentType { get; set; }
        public List<TemplateField> Fields { get; set; }
    }
}