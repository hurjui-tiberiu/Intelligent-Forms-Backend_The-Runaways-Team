using IntelligentFormsAPI.Domain.Enums;

namespace IntelligentFormsAPI.Domain.Entities
{
    public class Section
    {
        public string SectionName { get; set; } = null!;
        public string Content { get; set; } = null!;
        public ScannableDocumentType DocumentType { get; set; }
        public List<FormField> Fields { get; set; } = null!;
    }
}
