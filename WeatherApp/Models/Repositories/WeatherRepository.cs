using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using RestSharp.Serialization.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using WeatherApp.Models.OpenWeatherMapModels;

namespace WeatherApp.Models.Repositories
{
    // in this class i converting json object to c# class
    public interface IWeatherRepository 
    {
        public DailyWeatherResponse GetWeather(float lon,float lat); 
    }

    public class WeatherRepository : IWeatherRepository
    {
        public DailyWeatherResponse GetWeather(float lon, float lat)
        {
            string myApiKey = ConstantKey.OPEN_WEATHER_APPID;

            var client = new RestClient($"https://api.openweathermap.org/data/2.5/onecall?lat={lat}&lon={lon}&exclude=current,minutely,hourly&units=metric&appid={myApiKey}");

            var request = new RestRequest(Method.GET);

            IRestResponse restResponse = client.Execute(request);

            if (restResponse.IsSuccessful)
            {
                var content = JsonConvert.DeserializeObject<JToken>(restResponse.Content);

                return content.ToObject<DailyWeatherResponse>();
            }


            return null;
        }
    }
}
