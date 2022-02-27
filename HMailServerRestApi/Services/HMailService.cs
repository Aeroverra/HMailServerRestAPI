using HMailServerRestApi.Models.appsettings;
using Microsoft.Extensions.Options;

namespace HMailServerRestApi.Services
{
    public class HMailService
    {
        public HMailSettings Settings { get; set; }
        public hMailServer.Application App { get; set; }
        public HMailService(IOptions<HMailSettings> Options)
        {
            Settings = Options.Value;
            App = new hMailServer.Application();
            App.Authenticate(Settings.Username,Settings.Password);
        }
        public List<string> GetDomains()
        {
            var result = App.Domains.Names.Split(Environment.NewLine).ToList();
            Console.WriteLine(result);
            return result;
        }
        public List<string> GetAccounts(string domain)
        {
            var result = App.Domains.ItemByName[domain];
            hMailServer.Accounts accounts = result.Accounts;
       
            for(var x = 0;x<accounts.Count;x++)
            {
                var account = accounts[x];
           
            }
            return new();
        }
    }
}
