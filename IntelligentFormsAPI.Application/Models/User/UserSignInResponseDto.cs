namespace IntelligentFormsAPI.Application.Models
{
    public class UserSignInResponseDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        public string Address { get; set; } = null!;
        public string EmailAddress { get; set; } = null!;
    }
}
