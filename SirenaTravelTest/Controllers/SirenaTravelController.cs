using Microsoft.AspNetCore.Mvc;
using SirenaTravelTest.Services;

namespace SirenaTravelTest.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SirenaTravelController : BaseController
    {
        [HttpGet]
        public async Task<IActionResult> Get(string city_iata1, string city_iata2)
        {
           var airport1= await httpServices.GetAirportAsync(city_iata1);
            var airport2 = await httpServices.GetAirportAsync(city_iata2);
            var point1 = new Point(airport1.Location.Lon, airport1.Location.Lat);
            var point2 = new Point(airport2.Location.Lon, airport2.Location.Lat);
           var res= AccountantServies.CalculationBetweenPoints(point1, point2);
            return Ok(res);
        }

    }
}
