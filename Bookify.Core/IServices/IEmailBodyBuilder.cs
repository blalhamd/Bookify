namespace Bookify.Core.IServices
{
    public interface IEmailBodyBuilder
    {
        Task<string> GenerateEmailBody(string templateName,string imageUrl, string header, string body, string link, string linkTitle);
    }
}
