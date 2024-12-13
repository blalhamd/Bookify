namespace Bookify.Presentation.Controllers
{
	[Authorize]
	public class AuthorsController : Controller
	{
		private readonly IAuthorService _AuthorService;
		private readonly IWebHostEnvironment _webHostEnvironment;
        public AuthorsController(IAuthorService AuthorService, IWebHostEnvironment webHostEnvironment)
        {
            _AuthorService = AuthorService;
            _webHostEnvironment = webHostEnvironment;
        }

        [HttpGet]
		public async Task<ActionResult<IList<AuthorViewModel>>> Index()
		{
            var query = await _AuthorService.GetAllAsync();

			return View(query);
		}

        [HttpGet("Author/Details/{id}")]
        public async Task<ActionResult<AuthorViewModel>> Details(int id)
		{
			var query = await _AuthorService.GetByIdAsync(id);

			return View(query);
		}

		[Authorize(Roles = DefaultRole.Admin)]
		public IActionResult CreateForm()
		{
			return View();
		}

		[HttpPost]
		//[IgnoreAntiforgeryToken]
		[Authorize(Roles = DefaultRole.Admin)]
		public async Task<ActionResult> Create(CreateAuthorViewModel request)
		{
			if(!ModelState.IsValid)
			{
				return View(request);
			}

		    await _AuthorService.CreateAsync(request);

			return RedirectToAction(nameof(Index));
		}

		[Authorize(Roles = DefaultRole.Admin)]
		public async Task<IActionResult> Edit(int id)
		{
			var Author = await _AuthorService.GetByIdAsync(id);

			return View(Author);
		}

		[HttpPost("Authors/Edit/{id}")]
		[Authorize(Roles = DefaultRole.Admin)]
		public async Task<IActionResult> Edit(int id,CreateAuthorViewModel request)
		{
			if (!ModelState.IsValid)
			{
				return View(request);
			}

			await _AuthorService.UpdateAsync(id,request);

			return RedirectToAction(nameof(Index));
		}

		[Authorize(Roles = DefaultRole.Admin)]
		public async Task<IActionResult> DeleteForm(int id)
		{
			var Author = await _AuthorService.GetByIdAsync(id);

			return View(Author);
		}

		[HttpPost("Authors/Delete/{id}")]
		[Authorize(Roles = DefaultRole.Admin)]
		public async Task<IActionResult> Delete(int id)
		{
			await _AuthorService.DeleteAsync(id);

			return RedirectToAction(nameof(Index));
		}
	}
}
