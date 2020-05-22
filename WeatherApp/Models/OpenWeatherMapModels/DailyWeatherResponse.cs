using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherApp.Models.OpenWeatherMapModels
{
    // API returns Json object and I created C# classes to deserialize
    // that Json object to C# classes
    // and all This classes are on OpenWeatherMapModels Folder
    public class DailyWeatherResponse
    {
        public float Lon { get; set; }
        public float Lat { get; set; }
        public string Timezone { get; set; }
        public int Timezone_Offset { get; set; }
        public List<Daily> Daily { get; set; }

    }
}
