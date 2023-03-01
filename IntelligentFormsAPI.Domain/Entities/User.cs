namespace IntelligentFormsAPI.Domain.Entities
{
    public record User
    {
        public Guid Id { get; set;}
        public string Name { get; set; }
        public string Address { get; set; }
        public string EmailAddress { get; set; }
        public string Password { get; set; }
    }
}
