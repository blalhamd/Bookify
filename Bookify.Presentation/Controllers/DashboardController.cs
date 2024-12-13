namespace Bookify.Presentation.Controllers
{
	public class DashboardController : Controller
	{
		private readonly ISubscriberService _subscriberService;
		private readonly IBookCopyService _bookCopyService;
		private readonly IBookService _bookService;
        public DashboardController(ISubscriberService subscriberService, IBookCopyService bookCopyService, IBookService bookService)
        {
            _subscriberService = subscriberService;
            _bookCopyService = bookCopyService;
            _bookService = bookService;
        }

        public async Task<ActionResult> Index()
		{
			var model = new DashboardViewModel
			{
				BookCopiesCount = await _subscriberService.Count(),
				SubscribersCount = await _subscriberService.Count(),
				Books = await _bookService.GetLastEightBooks(),
				Subscribers = await _subscriberService.GetSubscriberDashboard()
			};

			return View(model);
		}

	}
}
