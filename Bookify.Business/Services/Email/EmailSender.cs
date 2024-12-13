namespace Bookify.Business.Services.Email
{
    public class EmailSender : IEmailSender // don't forget register it as service in conatiner <IEmailSender,EmailService>
    {
        private readonly MailSettings _settings;

        public EmailSender(IOptions<MailSettings> settings) // don't forget Binding in container
        {
            _settings = settings.Value;
        }

        public async Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            var message = new MailMessage()
            {
                From = new MailAddress(_settings.Email!, _settings.DisplayName),
                Body = htmlMessage,
                Subject = subject,
                IsBodyHtml = true,
            };

            message.To.Add(email);

            var stmpClient = new SmtpClient(_settings.Host!)
            {
                Port = _settings.Port!,
                Credentials = new NetworkCredential(_settings.Email, _settings.Passsword),
                EnableSsl = true,
            };

            await stmpClient.SendMailAsync(message);

            stmpClient.Dispose();
        }
    }
}
