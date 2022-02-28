using HMailLib;
using HMailLib.Models;
using Microsoft.AspNetCore.Mvc;

namespace HMailServerRestApi.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class AccountsController : Controller
    {
        public HMailService _hmail { get; set; }
        public AccountsController(HMailService hmail)
        {
            _hmail = hmail;
        }

        [HttpGet]
        public IActionResult GetAll([FromQuery] string DomainName)
        {
            var account = _hmail.GetAccounts(DomainName);
            return new JsonResult(account);
        }

        [HttpGet]
        public IActionResult GetById([FromQuery] string DomainName, int AccountId)
        {
            var account = _hmail.GetAccountById(DomainName, AccountId);
            return new JsonResult(account);
        }

        [HttpGet]
        public IActionResult GetByAddress([FromQuery] string DomainName, string AccountAddress)
        {
            var account = _hmail.GetAccountByAddress(DomainName, AccountAddress);
            return new JsonResult(account);
        }

        [HttpPost]
        public IActionResult Create([FromQuery] string DomainName, [FromBody] Account Account)
        {
            if (String.IsNullOrWhiteSpace(DomainName) || String.IsNullOrWhiteSpace(Account.Address))
            {
                return BadRequest("Missing Field! Domain and address is required!");
            }
            var account = _hmail.CreateAccount(DomainName, Account);
            return new JsonResult(account);
        }

        [HttpPatch]
        public IActionResult Update([FromQuery] string DomainName, int AccountId, [FromBody] Account Account)
        {
            var account = _hmail.UpdateAccount(DomainName, AccountId, Account);
            return new JsonResult(account);
        }

        [HttpDelete]
        public IActionResult Delete([FromQuery] string DomainName, int AccountId)
        {
            _hmail.DeleteAccount(DomainName, AccountId);
            return new OkResult();
        }
    }
}
