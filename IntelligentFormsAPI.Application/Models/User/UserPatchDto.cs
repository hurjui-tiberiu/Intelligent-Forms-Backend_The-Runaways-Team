namespace IntelligentFormsAPI.Application.Models.User
{
    public class UserPatchDto
    {
        public string? Name { get; set; }
        public string? Address { get; set; }
        public string? EmailAddress { get; set; }
        public string? Password { get; set; }
    }
}
