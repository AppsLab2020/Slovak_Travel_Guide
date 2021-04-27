using Slovak_Travel_Guide.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Slovak_Travel_Guide.Service
{
    class WeatherInfoProvider
    {
        const string API_KEY = "89a3e9905f514acfd1108cf3ee813b50";

        public async Task<WeatherInfo> GetLocation(double latitude, double longitude)
        {
            string requestUrl = CreateRequestUrl(latitude, longitude);
            string jsonString = "";
            
            using (HttpClient httpClient = new HttpClient())
            {
                HttpResponseMessage response = await httpClient.GetAsync(requestUrl);

                if(response.IsSuccessStatusCode)
                {
                    jsonString = await response.Content.ReadAsStringAsync();
                }
                else
                {
                    return null;
                }

                JsonDocument jsonDocument = JsonDocument.Parse(jsonString);

                return new WeatherInfo
                {
                    Temperature = (int)jsonDocument.RootElement.GetProperty("main").GetProperty("temp").GetDouble(),
                    Humidity = (int)jsonDocument.RootElement.GetProperty("main").GetProperty("temp").GetDouble(),
                    Pressure = (int)jsonDocument.RootElement.GetProperty("main").GetProperty("temp").GetDouble(),
                    ImageUrl = CreateImageUrl(jsonDocument.RootElement.GetProperty("weather").EnumerateArray().First().GetProperty("icon").GetString()),
                    Name = (string)jsonDocument.RootElement.GetProperty("main").GetProperty("temp").GetString()
                };
            }
        }
        public static string CreateImageUrl(string imageCode)
        {
            return $"https://openweathermap.org/img/w/{imageCode}.png";
        }
        private string CreateRequestUrl(double latitude, double longitude)
        {
            return $"https://api.openweathermap.org/data/2.5/weather?lat={latitude}&lon={longitude}&units=metric&appid={API_KEY}";
        }
    }
}
