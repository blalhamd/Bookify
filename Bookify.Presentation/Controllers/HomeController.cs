namespace Bookify.Presentation.Controllers
{
	[Authorize]
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;
		private readonly IBookService _bookService;
		private readonly IDataProtector _dataProtector;
        public HomeController(ILogger<HomeController> logger, IBookService bookService,IDataProtectionProvider protectionProvider)
        {
            _logger = logger;
            _bookService = bookService;
			_dataProtector = protectionProvider.CreateProtector("SecureKey");
        }

        public async Task<ActionResult> Index()
		{
            if (!User.Identity!.IsAuthenticated)
            {
                return RedirectToPage("Login", "Account", new { area = "Identity"});
            }

			var books = await _bookService.GetLastEightBooks();

			foreach (var item in books)
			{
				item.Id = _dataProtector.Protect(item.Id);
			}

            return View(books);
		}

		

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error(int statusCode = 500)
		{
			return View(new ErrorViewModel { ErrorCode = statusCode, ErrorMessage = ReasonPhrases.GetReasonPhrase(statusCode) });
		}

		public IActionResult CustomError(int statusCode = 500,string message = "Internal Server Error")
		{
			return View("Error",new ErrorViewModel { ErrorCode = statusCode, ErrorMessage = message });
		}
	}
}
