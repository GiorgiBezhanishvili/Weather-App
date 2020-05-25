using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WeatherApp.Models;
using WeatherApp.Models.OpenWeatherMapModels;
using WeatherApp.Models.Repositories;
using WeatherApp.ViewModel;

namespace WeatherApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IWeatherRepository _weatherRepository;
        private readonly ICityRepository _cityRepository;

       
        public HomeController(IWeatherRepository weatherRepository, ICityRepository cityRepository)
        {
            _weatherRepository = weatherRepository;
            _cityRepository = cityRepository;
        }

        public IActionResult Index(string cityName = "Tbilisi") // default city name is Tbilisi
        {
            // Coordinates for each city by name
            // this Cities Names Data already saved in CityRepository
            var lon = _cityRepository.GetLon(cityName);
            var lat = _cityRepository.GetLat(cityName);

            DailyWeatherResponse weatherResponse = _weatherRepository.GetWeather(lon,lat);

            List<WeatherInfoVM> CityWeather = new List<WeatherInfoVM>();

            if (weatherResponse != null)
            {
                // Filling CityWeather with given Data
                // there 0 index means today, other ones are next days
                CityWeather.Add(new WeatherInfoVM() { 
                Temp = weatherResponse.Daily[0].Temp.Day,   
                Humidity = weatherResponse.Daily[0].Humidity,
                Pressure = weatherResponse.Daily[0].Pressure,
                Wind = weatherResponse.Daily[0].Wind_Speed,
                WeatherCondition = weatherResponse.Daily[0].Weather[0].Description,
                Cloudness = weatherResponse.Daily[0].Clouds
                });

                for (int i = 1; i < 8; i++)
                {
                    CityWeather.Add(new WeatherInfoVM() {
                        Temp = weatherResponse.Daily[i].Temp.Day,
                        WeatherCondition = weatherResponse.Daily[i].Weather[0].Description
                    });
                }
                ViewBag.CityName = cityName;
                return View(CityWeather);
            }

            return View();
            
        }

        // eseni moyolilia da ar wamishlia :)
        #region moyolilebi
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        #endregion
    }
}
