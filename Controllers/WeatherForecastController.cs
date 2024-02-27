using InoDayJenkins.Classes;
using Microsoft.AspNetCore.Mvc;

namespace InoDayJenkins.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class WeatherForecastController : ControllerBase
	{
		private static readonly string[] Summaries = new[]
		{
		"Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
		};

		//private readonly ILogger<WeatherForecastController> _logger;

		private BusinessLogic _logic;

		public WeatherForecastController(/*ILogger<WeatherForecastController> logger,*/ BusinessLogic logic)
		{
			//_logger = logger;
			_logic = logic;
		}

		[HttpGet(Name = "GetWeatherForecast")]
		public IEnumerable<WeatherForecast> Get()
		{
			return Enumerable.Range(1, 5).Select(index => new WeatherForecast
			{
				Date = DateTime.Now.AddDays(index),
				TemperatureC = Random.Shared.Next(-20, 55),
				Summary = Summaries[Random.Shared.Next(Summaries.Length)]
			})
			.ToArray();
		}

		public IEnumerable<int> GetNumbers()
		{
			List<int> numbers = new List<int>() {1,2,3,4,5 };
			return numbers;
		}
	}
}