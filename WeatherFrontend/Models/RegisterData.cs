
namespace WeatherFrontend.Models
{
    public class RegisterData
    {
        public string? Id { get; set; }

        public string UserName { get; set; }
        public string Password { get; set; }

        public string Email { get; set; }

        public string ConfirmPassword { get; set; }

        public List<string> Favourites { get; set; } = new();
    }
}
