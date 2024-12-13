namespace Bookify.Business.Services.Email
{
    public class EmailBodyBuilder : IEmailBodyBuilder
    {
        private readonly IWebHostEnvironment _webHostEnvironment;

        public EmailBodyBuilder(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }

        public async Task<string> GenerateEmailBody(string templateName,string imageUrl, string header, string body, string link, string linkTitle)
        {
            var filePath = $"{_webHostEnvironment.WebRootPath}/templates/{templateName}";
            var template = await System.IO.File.ReadAllTextAsync(filePath);

            string imagePath = imageUrl;
            string imageFromGoogle = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTc9APxkj0xClmrU3PpMZglHQkx446nQPG6lA&s";

            template = template.Replace("[imageUrl]", imageFromGoogle)
                       .Replace("[header]", header)
                       .Replace("[body]", body)
                       .Replace("[link]", link)
                       .Replace("[linkTitle]", linkTitle);

            return template;
        }
    }
}
