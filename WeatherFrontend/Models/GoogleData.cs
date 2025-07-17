
namespace WeatherFrontend.Models
{
    public class GoogleData
    {
        
        public string? Id { get; set; }

        public string Email { get; set; }

        public List<string> Favourites { get; set; } = new();
    }
}

