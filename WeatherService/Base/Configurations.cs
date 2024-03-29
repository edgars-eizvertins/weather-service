using System.IO;
using Microsoft.Extensions.Configuration;

namespace WeatherService.Base;

public static class AppSettings
{
	public static Settings Settings { get; private set; }

	static AppSettings()
	{
		var builder = new ConfigurationBuilder()
			.SetBasePath(Directory.GetCurrentDirectory())
			.AddJsonFile("config.default.json")
			.AddJsonFile("config.json", true);

		Settings = builder.Build().Get<Settings>();
	}
}

public class Settings
{
	public WeatherService WeatherService { get; set; }
}

public class WeatherService
{
	public string Port { get; set; }
	public string AppId { get; set; }
	public string ApiUrl { get; set; }
	public string Units { get; set; }
	public string Latitude { get; set; }
	public string Longitude { get; set; }
	public string Host { get; set; }
}