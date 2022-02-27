namespace HMailServerRestApi.Models.appsettings
{
    public class HMailSettings
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public List<string> Whitelist { get; set; } = new();

    }
}
