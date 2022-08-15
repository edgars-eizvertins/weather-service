using System.Net.Http;
using WeatherService.OpenWeather.Classes;
using System.Net.Http.Json;
using System;
using WeatherService.Base;
using System.Threading.Tasks;

namespace WeatherService.OpenWeather;

public class ForecastProvider
{
	public string Units { get; init; }
	public string AppId { get; init; }

	public ForecastProvider(string units, string appId) => (Units, AppId) = (units, appId);        

	public async Task<WeatherData> GetWeather(string latitude, string longitude)
	{
		var httpClient = new HttpClient();
		httpClient.BaseAddress = new Uri(AppSettings.Settings.WeatherService.ApiUrl);
		var data = await httpClient.GetFromJsonAsync<WeatherData>(
			@$"onecall?units={this.Units}&lat={latitude}&lon={longitude}&appid={this.AppId}"
		);			
		return data;
	}
}