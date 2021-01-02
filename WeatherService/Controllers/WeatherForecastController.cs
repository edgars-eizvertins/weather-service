using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WeatherService.Base;
using WeatherService.MapView;
using WeatherService.OpenWeather;
using WeatherService.OpenWeather.Classes;
using WeatherService.OpenWeather.MapView;

namespace WeatherService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public async Task<WeatherDataView> Get()
        {
			var forecastProvider = new ForecastProvider(
				AppSettings.Settings.WeatherService.Units,
				AppSettings.Settings.WeatherService.AppId
			);
			var data = await forecastProvider.GetWeather(
				AppSettings.Settings.WeatherService.Latitude,
				AppSettings.Settings.WeatherService.Longitude
			);
			var mapper = new ViewMapper();
			return mapper.Map(data);
		}
    }
}
