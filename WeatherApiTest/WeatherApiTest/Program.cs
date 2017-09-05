using System;
using System.Runtime.Serialization;

namespace WeatherApiTest
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherApiClient.GetWeatherForecast();
        }
    }
}
