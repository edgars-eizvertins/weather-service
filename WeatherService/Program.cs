using System;
using System.Linq;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using WeatherService.Base;

//Run using this
//
// http://localhost:1984/WeatherForecast

namespace WeatherService;

public class Program
{
	public static void Main(string[] args)
	{
		CreateHostBuilder(args).Build().Run();
	}

	public static IHostBuilder CreateHostBuilder(string[] args)
	{
		Console.WriteLine("Hello!");
		AddParameters(args);
		return Host.CreateDefaultBuilder(args)
			.ConfigureWebHostDefaults(webBuilder =>
			{
				webBuilder.UseStartup<Startup>();
				webBuilder.UseUrls($"http://{AppSettings.Settings.WeatherService.Host}:{AppSettings.Settings.WeatherService.Port}");
			});
	}

	private static void AddParameters(string[] args)
	{
		foreach (var arg in args) {
			Console.WriteLine("Parameter: " + arg);
		}
		if (args.Count() > 0) {
			AppSettings.Settings.WeatherService.AppId = args[0];
		}
		if (args.Count() > 1) {
			AppSettings.Settings.WeatherService.Latitude = args[1];
		}
		if (args.Count() > 2) {
			AppSettings.Settings.WeatherService.Longitude = args[2];
		}
		if (args.Count() > 3) {
			AppSettings.Settings.WeatherService.Units = args[3];
		}
	}
}