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

	public static IHostBuilder CreateHostBuilder(string[] args) =>
		Host.CreateDefaultBuilder(args)
			.ConfigureWebHostDefaults(webBuilder => {
				webBuilder.UseStartup<Startup>();
				webBuilder.UseUrls($"http://localhost:{AppSettings.Settings.WeatherService.Port}");
			});
}