namespace Bookify.Business.Services.Email
{
    public class MailSettings // don't forget to Bind it in program.cs
    {
        public string DisplayName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Passsword { get; set; } = null!;
        public string Host { get; set; } = null!;
        public int Port { get; set; }
    }
}
