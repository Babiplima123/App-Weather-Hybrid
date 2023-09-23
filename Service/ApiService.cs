using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weather_App_Mobile_Hybrid.Models;

namespace Weather_App_Mobile_Hybrid.Service
{
    public static class ApiService
    {
        public static async Task<Root> GetWeather(double latitude, double longitude)
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetStringAsync(string.Format("https://api.openweathermap.org/data/2.5/forecast?lat={0}&log={1}&appid=94a29e0f6380fdd35d57468bfb9d018f",latitude,longitude));
            return JsonConvert.DeserializeObject<Root>(response);
        }

        public static async Task<Root> GetWeatherByCity(string city)
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetStringAsync(string.Format("https://api.openweathermap.org/data/2.5/forecast?q={0}&appid=94a29e0f6380fdd35d57468bfb9d018f",city));
            return JsonConvert.DeserializeObject<Root>(response);
        }
    }
}
