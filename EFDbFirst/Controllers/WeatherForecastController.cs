using EFDbFirst.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EFDbFirst.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly AngularStudentDbContext _DbContext;

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger , AngularStudentDbContext DbContext)
        {
            _logger = logger;
            _DbContext = DbContext;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<dynamic> Get()
        {
            return _DbContext.Depts.ToList();
        }
    }
}
