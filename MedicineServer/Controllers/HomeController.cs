using Microsoft.AspNetCore.Mvc;

namespace MedicineServer.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
	    [HttpGet]
	    public string Get()
	    {
		    return "Hello, world!";
	    }
    }
}