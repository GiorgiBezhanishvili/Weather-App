using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherApp.Models
{
    public class City
    {
        public City(int id,string cityName,float lat,float lon)
        {
            Id = id;
            CityName = cityName;
            Lat = lat;
            Lon = lon;
        }

        public int Id { get; set; }
        public string CityName { get; set; }
        public float Lat { get; set; }
        public float Lon { get; set; }
    }
}
