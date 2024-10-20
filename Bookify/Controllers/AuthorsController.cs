namespace Bookify.Controllers
{
	public class AuthorsController : Controller
	{
		private readonly IAuthorService _AuthorService;

		public AuthorsController(IAuthorService AuthorService)
		{
			_AuthorService = AuthorService;
		}

		public async Task<ActionResult<IList<AuthorViewModel>>> Index()
		{
			var query = await _AuthorService.GetAllAsync();

			return View(query);
		}

		public async Task<ActionResult<AuthorViewModel>> Details(int id)
		{
			var query = await _AuthorService.GetByIdAsync(id);

			return View(query);
		}

		public IActionResult CreateForm()
		{
			return View();
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<ActionResult> Create(CreateAuthorViewModel request)
		{
			if(!ModelState.IsValid)
			{
				return View(request);
			}

		    await _AuthorService.CreateAsync(request);

			return RedirectToAction(nameof(Index));
		}

		public async Task<IActionResult> Edit(int id)
		{
			var Author = await _AuthorService.GetByIdAsync(id);

			return View(Author);
		}

		[HttpPost("Authors/Edit/{id}")]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Edit(int id,CreateAuthorViewModel request)
		{
			if (!ModelState.IsValid)
			{
				return View(request);
			}

			await _AuthorService.UpdateAsync(id,request);

			return RedirectToAction(nameof(Index));
		}

		public async Task<IActionResult> DeleteForm(int id)
		{
			var Author = await _AuthorService.GetByIdAsync(id);

			return View(Author);
		}

		[HttpPost("Authors/Delete/{id}")]
		public async Task<IActionResult> Delete(int id)
		{
			await _AuthorService.DeleteAsync(id);

			return RedirectToAction(nameof(Index));
		}
	}
}
