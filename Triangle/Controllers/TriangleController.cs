using Microsoft.AspNetCore.Mvc;
using Triangle.Services;

namespace Triangle.Controllers
{
    [ApiController]
    [Route("")]
    public class TriangleController : ControllerBase
    {
        private readonly ILogger<TriangleController> _logger;
        private readonly ITriangleService _triangleService;

        public TriangleController(ILogger<TriangleController> logger, ITriangleService triangleService)
        {
            _logger = logger;
            _triangleService = triangleService;
        }

        [HttpGet(Name = "")]
        public int Get()
        {
            return _triangleService.ComputeMaxTotal();
            //return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            //{
            //    Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            //    TemperatureC = Random.Shared.Next(-20, 55),
            //    Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            //})
            //.ToArray();
        }
    }
}