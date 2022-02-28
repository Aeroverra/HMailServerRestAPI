using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMailLib.Models
{
    public class HMailSettings
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public List<string> Whitelist { get; set; } = new();
    }
}
