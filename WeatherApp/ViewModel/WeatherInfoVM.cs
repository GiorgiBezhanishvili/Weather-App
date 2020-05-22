using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherApp.ViewModel
{
    public class WeatherInfoVM
    {
        public float Temp { get; set; }
        public float Wind { get; set; }
        public int Humidity { get; set; }
        public int Pressure { get; set; }
        public float Cloudness { get; set; }
        public string WeatherCondition { get; set; }
    }
}
