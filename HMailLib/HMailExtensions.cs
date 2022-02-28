
using hMailServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HMailLib
{
    public static class HMailExtensions
    {
        public static List<Domain> ToList(this Domains domains)
        {
            var list = new List<Domain>();
            for (int x = 0; x < domains.Count; x++)
            {
                list.Add(domains[x]);
            }
            return list;
        }
        public static List<Account> ToList(this Accounts accounts)
        {
            var list = new List<Account>();
            for (int x = 0; x < accounts.Count; x++)
            {
                list.Add(accounts[x]);
            }
            return list;
        }

        public static void UpdateValues(this object destination, object source)
        {
            var properties = destination
                .GetType()
                .GetProperties()
                .Where(x => x.PropertyType == typeof(string)
                    || x.PropertyType == typeof(bool)
                    || x.PropertyType == typeof(int)
                    || x.PropertyType == typeof(float)
                    || x.PropertyType == typeof(bool?)
                    || x.PropertyType == typeof(int?)
                    || x.PropertyType == typeof(float?)
                )
                .ToList();


            foreach (var property in properties)
            {
                //Console.WriteLine("{0} {1}={2}", property.PropertyType, property.Name, property.GetValue(destination, null));
                PropertyInfo prop = source.GetType().GetProperty(property.Name);
                if (prop != null && prop.GetValue(source) != null)
                {
                    property.SetValue(destination, prop.GetValue(source), null);
                }
            }
        }
    }
}
