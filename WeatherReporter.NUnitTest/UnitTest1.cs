using Encapsulation.Models;

namespace MyWeatherReporter.NUnitTest
{
    public class WeatherReporterTests
    {
        private WeatherReporter _weatherReporterLondonHot;
        private WeatherReporter _weatherReporterCaliforniaJustRight;

        [SetUp]
        public void Setup()
        {
            _weatherReporterLondonHot = new ("London", 32); 
            _weatherReporterCaliforniaJustRight = new("California", 19);
        }

        [Test]
        public void CheckWeatherTest()
        {            
            _weatherReporterLondonHot.CheckWeather().Should().Be("🌦");
            _weatherReporterCaliforniaJustRight.CheckWeather().Should().Be("🌅");
        }

        [Test]
        public void CheckTemperatureTest()
        {            
            _weatherReporterLondonHot.CheckTemperature().Should().Be("It's too hot 🥵!");
            _weatherReporterCaliforniaJustRight.CheckTemperature().Should().Be("Ahhh...it's just right 😊!");
        }
    }
}