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

		private readonly ILogger<WeatherForecastController> _logger;

		private BusinessLogic _logic;

		public WeatherForecastController() { }

        public WeatherForecastController(ILogger<WeatherForecastController> logger, BusinessLogic logic)
		{
			_logger = logger;
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

        [HttpPost(Name = "IsPrimeNumber")]
        public bool IsPrimeNumber(int number)
        {
            if (number == 0 || number == 1)
            {
                return false;
            }
            else
            {
                for (int a = 2; a <= number / 2; a++)
                {
                    if (number % a == 0)
                    {
                        return false;
                    }

                }
                return true;
            }
        }
    }
}