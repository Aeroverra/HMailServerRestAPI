using HMailServerRestApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace HMailServerRestApi.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class DomainsController : Controller
    {
        public HMailService _hmail { get; set; }
        public DomainsController(HMailService hmail)
        {
            _hmail = hmail;
        }
        [HttpGet(Name = "GetDomains")]
        public IActionResult GetDomains()
        {
            var result = _hmail.GetDomains();
            return Content(result.ToString());
        }
    }
}
