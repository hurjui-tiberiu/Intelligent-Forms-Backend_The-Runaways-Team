namespace IntelligentFormsAPI.Domain.Entities
{
    public record Submission
    {
        public Guid Id { get; set; }
        public List<SubmissionField> Fields { get; set; } = null!;
        public List<string> Sections { get; set; } = null!;
        public DateTime TimeStamp { get; set; }
    }
}
