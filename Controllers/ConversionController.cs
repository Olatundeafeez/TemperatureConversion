using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace Temparature_Converter.Controllers
{
    [Route("api/[controller]")]
    //[ApiController]
    public class ConversionController : ControllerBase
    {
        [HttpGet(nameof(ConvertFahrenheitToCelcius))]
        public IActionResult ConvertFahrenheitToCelcius(double fahrenheit)
        {
        return Ok();
        }

        [HttpGet(nameof(ConvertCelciusToFahrenheit))]
        public IActionResult ConvertCelciusToFahrenheit(double Celcius)
        {
            return Ok();
        }

    }
}
