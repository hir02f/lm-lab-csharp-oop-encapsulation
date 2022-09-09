using System;
namespace Encapsulation.Models
{
    public class WeatherReporter
    {
        private string _location;
        private double _temperature;
        private const double FAHRENHEITMULTIPLIER = 9 / 5;
        private const int FAHRENHEITADD = 32;
        private const int CONSIDEREDHOT = 30;
        private const int CONSIDEREDCOLD = 10;

        public WeatherReporter(string location, double temperature)
        {
            _location = location;
            _temperature = temperature;
        }

        public string PrintWeatherReport()
        {
            double newTemp = FAHRENHEITMULTIPLIER * _temperature + FAHRENHEITADD;
            return $"I am in {_location} and it is {CheckWeather()}. {CheckTemperature()}. The temperature in Fahrenheit is {newTemp}.";
        }

        public string CheckWeather()
        {
            return _location == "London" ? "🌦" : _location == "California" ? "🌅" : _location == "Cape Town" ? "🌤" : "🔆";
        }

        public string CheckTemperature()
        {
            return _temperature > CONSIDEREDHOT ? "It's too hot 🥵!" : _temperature < CONSIDEREDCOLD ? "It's too cold 🥶!" : "Ahhh...it's just right 😊!";
        }        
    }
}

