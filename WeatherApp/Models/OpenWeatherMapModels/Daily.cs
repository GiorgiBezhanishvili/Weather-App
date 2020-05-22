using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherApp.Models.OpenWeatherMapModels
{
    public class Daily
    {
        public int Dt { get; set; }
        public int Sunrise { get; set; }
        public int Sunset { get; set; }
        public Temp Temp { get; set; }
        public FeelsLike Feels_Like { get; set; }
        public int Pressure { get; set; }
        public int Humidity { get; set; }
        public float Dew_Point { get; set; }
        public float Wind_Speed { get; set; }
        public string Wind_Deg { get; set; }
        public List<Weather> Weather { get; set; }
        public int Clouds { get; set; }
        public float Rain { get; set; }
        public float Uvi { get; set; }
        public int Visibility { get; set; }

    }
}
