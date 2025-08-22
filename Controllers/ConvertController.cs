using Microsoft.AspNetCore.Mvc;

namespace NumberToWordsWebApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ConvertController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get(string number)
        {
            if (decimal.TryParse(number, out decimal value))
            {
                string words = value.ToWords(); // Uses NumberToWord extension
                if (value < 1 && value > 0)
                {
                    words = words.Replace("DOLLARS AND ", "");
                }
                return Ok(new { result = words });
            }

            return BadRequest(new { error = "Invalid number format." });
        }
    }
}
