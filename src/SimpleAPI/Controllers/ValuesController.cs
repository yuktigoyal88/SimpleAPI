using Microsoft.AspNetCore.Mvc;

namespace SimpleAPI.Controllers
{
    
    [ApiController]
    [Route("[controller]")]
    public class ValuesController : ControllerBase
    {
        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
        return "Les Jackson";
        }
    }
}