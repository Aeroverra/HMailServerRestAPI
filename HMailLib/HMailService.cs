using HMailLib.Models;

using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMailLib
{
    public class HMailService
    {
        public hMailServer.Application App { get; set; } = new hMailServer.Application();
        public HMailService(IOptions<HMailSettings> Options)
        {
            var settings = Options.Value;
            App.Authenticate(settings.Username, settings.Password);
        }

        public HMailService(string username, string password)
        {
            App.Authenticate(username, password);
        }
        public List<Domain> GetDomains()
        {
            List<Domain> domains = new List<Domain>();
            var hdomains = App.Domains.ToList();
            foreach (var hdomain in hdomains)
            {
                var domain = new Domain();
                domain.UpdateValues(hdomain);
                domains.Add(domain);
            }
            return domains;
        }

        public hMailServer.Domain GetDomainByName(string domainName)
        {
            return App.Domains.ItemByName[domainName];
        }

        public List<Account> GetAccounts(string domainName)
        {
            List<Account> accounts = new List<Account>();
            var domain = App.Domains.ItemByName[domainName];
            var haccounts = domain.Accounts.ToList();
            foreach (var haccount in haccounts)
            {
                var account = new Account();
                account.UpdateValues(haccount);
                accounts.Add(account);
            }

            return accounts;
        }
        public Account GetAccountById(string domainName, int id)
        {
            var domain = App.Domains.ItemByName[domainName];
            var account = domain.Accounts.ItemByDBID[id];
            var response = new Account();
            response.UpdateValues(account);
            return response;
        }
        public Account GetAccountByAddress(string domainName, string address)
        {
            var domain = App.Domains.ItemByName[domainName];
            var account = domain.Accounts.ItemByAddress[address];
            var response = new Account();
            response.UpdateValues(account);
            return response;
        }
        public Account CreateAccount(string domainName, Account model)
        {
            return CreateAccount(domainName, (object)model);
        }
        public Account CreateAccount(string domainName, object model)
        {
            var domain = App.Domains.ItemByName[domainName];
            var account = domain.Accounts.Add();
            account.UpdateValues(model);
            account.Save();

            var response = new Account();
            response.UpdateValues(account);
            return response;
        }
        public Account UpdateAccount(string domainName, int accountId, Account model)
        {
            var domain = App.Domains.ItemByName[domainName];
            var account = domain.Accounts.ItemByDBID[accountId];
            account.UpdateValues(model);
            account.Save();

            var response = new Account();
            response.UpdateValues(account);
            return response;
        }
        
        public void DeleteAccount(string domainName, int accountId)
        {
            var domain = App.Domains.ItemByName[domainName];
            var account = domain.Accounts.ItemByDBID[accountId];
            account.Delete();
        }
    }
}
