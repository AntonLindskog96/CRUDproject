using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System;

namespace CRUDproject
{
    public class WeatherService
    {
        private readonly string apiKey = "c00a49543d7db03fb1b9de0bd8f85d31"; // Replace with your OpenWeatherMap API key
        private readonly HttpClient client;

        public WeatherService()
        {
            client = new HttpClient();
        }

        public async Task<string> GetWeatherAsync(string city)
        {
            string url = $"http://api.openweathermap.org/data/2.5/weather?q=Gothenburg,Sweden&appid=c00a49543d7db03fb1b9de0bd8f85d31&units=metric"; // Metric for Celsius
            HttpResponseMessage response = await client.GetAsync(url);

            if (!response.IsSuccessStatusCode)
            {
                return "Error fetching weather data.";
            }

            string responseBody = await response.Content.ReadAsStringAsync();
            dynamic weatherData = JsonConvert.DeserializeObject(responseBody);

            if (weatherData != null && weatherData.main != null)
            {
                string temperature = weatherData.main.temp;
                string weatherDescription = weatherData.weather[0].description;
                string cityName = weatherData.name;

                return $"Weather in {cityName}: {weatherDescription}, {temperature}°C";
            }

            return "Unable to retrieve weather data.";
        }
    }
}
