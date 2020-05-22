using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherApp.Models.OpenWeatherMapModels
{
    public class FeelsLike
    {
        public float Day { get; set; }
        public float Night { get; set; }
        public float Eve { get; set; }
        public float Mor { get; set; }
    }
}
