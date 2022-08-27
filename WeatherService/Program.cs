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

	public static IHostBuilder CreateHostBuilder(string[] args) {
		Console.WriteLine("Hello!");
		foreach (var arg in args) {
			Console.WriteLine("Parameter: " + arg);
		}
		if (String.IsNullOrEmpty(AppSettings.Settings.WeatherService.AppId)) {
			AppSettings.Settings.WeatherService.AppId = args.FirstOrDefault();
		}
		return Host.CreateDefaultBuilder(args)
			.ConfigureWebHostDefaults(webBuilder => {
				webBuilder.UseStartup<Startup>();
				webBuilder.UseUrls($"http://{AppSettings.Settings.WeatherService.Host}:{AppSettings.Settings.WeatherService.Port}");
			});
	}
}