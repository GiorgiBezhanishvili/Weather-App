using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherApp.Models.Repositories
{
    // for saving cities data and some function to work with them
    public interface ICityRepository 
    {
        public float GetLat(string cityName);
        public float GetLon(string cityName);
        public List<City> GetCityData();
    }
    public class CityRepository : ICityRepository
    {
        private List<City> CityData = new List<City>()
        {
            //City object contains id, name and coordinates (latitude and longtitude)
            new City(1,"Tbilisi",41.6941109f,44.8336792f),
            new City(2,"Kutaisi",42.26791f,42.6945915f),
            new City(3,"Batumi",41.6422806f,41.6339188f),
            new City(4,"Chiatura",42.2980614f,43.2988892f)
        };

        public List<City> GetCityData()
        {
            return CityData.ToList();
        }

        public float GetLat(string cityName)
        {
            var l = CityData.Where(n => n.CityName == cityName).Select(la => la.Lat);
            var lat = l.ElementAt(0);
            return lat;
        }

        public float GetLon(string cityName)
        {
            var l = CityData.Where(n => n.CityName == cityName).Select(la => la.Lon);
            var lon = l.ElementAt(0);
            return lon;
        }
    }
}
