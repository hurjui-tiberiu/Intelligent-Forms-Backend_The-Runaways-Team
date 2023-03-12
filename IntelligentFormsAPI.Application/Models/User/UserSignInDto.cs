namespace IntelligentFormsAPI.Application.Models
{
    public record UserSignInDto
    {
        public string EmailAddress { get; set; } = null!;
        public string Password { get; set; } = null!;
    }
}
