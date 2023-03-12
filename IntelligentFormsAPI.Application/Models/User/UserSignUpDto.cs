namespace IntelligentFormsAPI.Application.Models
{
    public class UserSignUpDto
    {
        public string Name { get; set; } = null!;
        public string Address { get; set; } = null!;
        public string EmailAddress { get; set; } = null!;
        public string Password { get; set; } = null!;
    }
}
