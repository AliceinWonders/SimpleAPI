using Microsoft.AspNetCore.Mvc;

namespace Administration.Controllers
{
    [ApiController]
    [Route("/")]
    public class HealthCheckController : ControllerBase
    {

        [HttpGet("/healthycheck")]
        public ActionResult HealthyCheck()
        {
            return Ok("Healthy");
        }
    }
}