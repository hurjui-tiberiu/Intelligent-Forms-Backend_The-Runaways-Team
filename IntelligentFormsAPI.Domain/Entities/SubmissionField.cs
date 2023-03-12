namespace IntelligentFormsAPI.Domain.Entities
{
    public record SubmissionField
    {
        public string Label { get; set; } = null!;
        public string Value { get; set; } = null!;
    }
}
