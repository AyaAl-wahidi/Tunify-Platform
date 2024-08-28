namespace Tunify_Platform.Models.DTO
{
    public class RegisterDTO
    {
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public IList<string> Roles { get; set; }
    }
}