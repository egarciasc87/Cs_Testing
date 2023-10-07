using Microsoft.AspNetCore.Mvc;
using CalculatorDomain;

namespace CalculatorWeb.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculatorController : ControllerBase
    {
        //[HttpGet(Name = "GetWeatherForecast")]
        //public IEnumerable<WeatherForecast> Get()
        //{
        //}

        [HttpGet("Add/{num_1}/{num_2}")]
        public int Get(int num_1, int num_2)
        {
            var calculator = new Calculator();
            return calculator.Sum(num_1, num_2);
        }
    }
}