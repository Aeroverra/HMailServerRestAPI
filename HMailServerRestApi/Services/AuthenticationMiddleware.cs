using HMailLib.Models;
using Microsoft.Extensions.Options;
using System.Text;

namespace HMailServerRestApi.Services
{
    public class AuthenticationMiddleware
    {
        https://www.cloudflare.com/ips-v4
            https://www.cloudflare.com/ips/
            https://www.cloudflare.com/ips-v6
        private readonly RequestDelegate _next;
        public AuthenticationMiddleware(RequestDelegate next)
        {
            _next = next;

        }
        public async Task Invoke(HttpContext context, IOptions<HMailSettings> options)
        {
            var settings = options.Value;

            var clientIP = context.Connection.RemoteIpAddress.ToString();

            //ToDo: Validate the client ip actually belongs to cloudflare otherwise spoofing is possible
            if (settings.UseCloudflareIPHeader)
            {
                var cloudflareIp = context.Request.Headers["CF-Connecting-IP"].ToString();
                if (!String.IsNullOrWhiteSpace(cloudflareIp))
                {
                    clientIP = cloudflareIp;
                }
            }

            if (!settings.Whitelist.Contains(clientIP))
            {
                Console.WriteLine($"{clientIP} NOT WHITELISTED!");
                context.Response.StatusCode = 418;
                context.Response.ContentType = "application/json";
                await context.Response.WriteAsync("{\"Aeroverra:\" \"https://github.com/Aeroverra\"}", Encoding.UTF8);
                return;
            }
            await _next.Invoke(context);
        }
    }
}
