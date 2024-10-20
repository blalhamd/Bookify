namespace Bookify.Controllers
{
	public class BooksController : Controller
	{
		private readonly IBookService _BookService;

		public BooksController(IBookService BookService)
		{
			_BookService = BookService;
		}

		public async Task<ActionResult<IList<BookViewModel>>> Index()
		{
			var query = await _BookService.GetAllAsync();

			return View(query);
		}

		public async Task<ActionResult<BookViewModel>> Details(int id)
		{
			var query = await _BookService.GetByIdAsync(id);

			return View(query);
		}

		public IActionResult CreateForm()
		{
			return View();
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<ActionResult> Create(CreateBookViewModel request)
		{
			if(!ModelState.IsValid)
			{
				return View(request);
			}

		    await _BookService.CreateAsync(request);

			return RedirectToAction(nameof(Index));
		}

		public async Task<IActionResult> Edit(int id)
		{
			var Book = await _BookService.GetByIdAsync(id);

			return View(Book);
		}

		[HttpPost("Books/Edit/{id}")]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Edit(int id,CreateBookViewModel request)
		{
			if (!ModelState.IsValid)
			{
				return View(request);
			}

			await _BookService.UpdateAsync(id,request);

			return RedirectToAction(nameof(Index));
		}

		public async Task<IActionResult> DeleteForm(int id)
		{
			var Book = await _BookService.GetByIdAsync(id);

			return View(Book);
		}

		[HttpPost("Books/Delete/{id}")]
		public async Task<IActionResult> Delete(int id)
		{
			await _BookService.DeleteAsync(id);

			return RedirectToAction(nameof(Index));
		}
	}
}
