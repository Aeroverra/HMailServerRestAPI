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
        public bool WhiteListEnabled { get; set; }
        public bool UseCloudflareIPHeader { get; set; }
        public List<string> Whitelist { get; set; } = new();
    }
}
