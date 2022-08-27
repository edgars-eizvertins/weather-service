using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace WeatherService.Controllers;

[ApiController]
[Route("")]
public class HomeController : ControllerBase
{
	private readonly ILogger<HomeController> _logger;

	public HomeController(ILogger<HomeController> logger)
	{
		_logger = logger;
	}

	[HttpGet]
	public async Task<string> Get()
	{		
		return await Task.FromResult("Api for weather");
	}
}