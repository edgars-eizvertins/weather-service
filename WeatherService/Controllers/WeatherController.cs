using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WeatherService.Base;
using WeatherService.MapView;
using WeatherService.OpenWeather;
using WeatherService.OpenWeather.MapView;

namespace WeatherService.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherController : ControllerBase
{
	private readonly ILogger<WeatherController> _logger;

	public WeatherController(ILogger<WeatherController> logger)
	{
		_logger = logger;
	}

	[HttpGet]
	public async Task<WeatherDataView> Get(string lat, string lon)
	{
		var forecastProvider = new ForecastProvider(
			AppSettings.Settings.WeatherService.Units,
			AppSettings.Settings.WeatherService.AppId
		);
		var data = await forecastProvider.GetWeather(
			lat ?? AppSettings.Settings.WeatherService.Latitude,
			lon ?? AppSettings.Settings.WeatherService.Longitude
		);
		var mapper = new ViewMapper();
		return mapper.Map(data);
	}
}