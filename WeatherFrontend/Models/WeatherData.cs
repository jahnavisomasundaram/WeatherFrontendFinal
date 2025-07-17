
namespace WeatherFrontend.Models
{
    public class WeatherData
    {
        public string? Id { get; set; }

        public string City { get; set; } = string.Empty;
        public double Temperature { get; set; }
        public string Description { get; set; } = string.Empty;

        public int Humidity { get; set; }

        public double Longitude { get; set; }

        public int Sunrise { get; set; }

    }
}
