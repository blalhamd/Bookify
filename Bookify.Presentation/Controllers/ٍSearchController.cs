namespace Bookify.Presentation.Controllers
{
    public class SearchController : Controller
    {
        private readonly IDataProtector _protector;
        private readonly IBookService _bookService;
        public SearchController(IDataProtectionProvider dataProtection, IBookService bookService)
        {
            _protector = dataProtection.CreateProtector(purpose: "SecureKey");
            _bookService = bookService;
        }


        [HttpGet]
        public async Task<ActionResult> Index()
        {
            return View();
        }

        // to display book details , implemtation it is like Details that exist in BookController,you can use Details that exist in BookController too...
        [HttpGet("Search/Details/{id}")]
        public async Task<ActionResult> Details(string id)
        {
            var unprotectedId = int.Parse(_protector.Unprotect(id));

            var book = await _bookService.GetByIdAsync(unprotectedId);

            return View(book);
        }

        // for Typeahead package

        [HttpGet]
        public async Task<IActionResult> FindBook(string search)
        {
            var books = await _bookService.FindAsync(search);

            foreach (var book in books)
            {
                book.Id = _protector.Protect(book.Id.ToString());
            }

            return Ok(books); // must return Ok Or Json Not View
        }
    }
}
