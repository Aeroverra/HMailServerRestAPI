using HMailLib;
using HMailLib.Models;
using Microsoft.AspNetCore.Mvc;

namespace HMailServerRestApi.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class DomainsController : Controller
    {
        public HMailService _hmail { get; set; }
        public DomainsController(HMailService hmail)
        {
            _hmail = hmail;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var domains = _hmail.GetDomains();
            return new JsonResult(domains);
        }

    }
}
