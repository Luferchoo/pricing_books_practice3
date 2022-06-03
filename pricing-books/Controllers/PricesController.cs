using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace pricing_books.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PricesController : ControllerBase
    {
        public IActionResult GetPrice()
        {
            return null;
        }
    }
}
