using Microsoft.AspNetCore.Mvc;

namespace Introduction.WebAPI.Controllers
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

        [HttpGet(Name = "GetWeatherForecast")] //u pozadini da svaka ruta ima posebno ime

        //Opcionalni su ako stavimo upitnik i postavimo ih na null vrijednosti
        //Ako ne stavimo na defaultnu vrijednost, bit ?e required
        //https://localhost:7193/weatherforecast?date=02-09-2024&summary=cool
        public IEnumerable<WeatherForecast> Get(DateOnly? date=null,string summary="")
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpGet]
        //[Route("getbyid")] opcionalno biranje koji je query
        [Route("getbyid/{id}")] //nije query parametar jer mora imati parametar
        public string GetWeatherForecast(int id)
        {
            return "Cool";
        }

        [HttpPost]
        public bool InsertWeatherSummary(WeatherForecast forecast)
        {
            return true;
        }
    }
}
