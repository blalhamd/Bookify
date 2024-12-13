namespace Bookify.Presentation.Controllers
{
	[Authorize]
	public class BooksController : Controller
	{
		private readonly IBookService _BookService;
		private readonly IAuthorService _AuthorService;
		private readonly ICategoryService _CategoryService;
		private readonly IMapper _mapper;
		private readonly IDataProtector _dataProtector;
		private readonly List<string> _extensions = new List<string>() { ".jpg", ".png", ".jpeg" };
		private readonly int _MaxSize = 2097152;
		public BooksController(IBookService BookService,
			IAuthorService authorService,
			IMapper mapper,
			ICategoryService categoryService,
			IDataProtectionProvider dataProtectionProvider)
		{
			_BookService = BookService;
			_AuthorService = authorService;
			_mapper = mapper;
			_CategoryService = categoryService;
			_dataProtector = dataProtectionProvider.CreateProtector(purpose: "MySecureKey");
		}

		public async Task<ActionResult<IList<BookViewModel>>> Index(string searchTerm = null)
		{
			var query = await _BookService.GetAllAsync();
			
			if(searchTerm != null)
				query = query.Where(x=> x.Title.ToLower().Contains(searchTerm.ToLower())).ToList();
			
			foreach(var item in query)
				item.Id = _dataProtector.Protect(item.Id.ToString());

			return View(query);
		}

		public async Task<ActionResult<BookViewModel>> Details(string id)
		{
			var unprotectedId = UnProtectedId(id);

			if (unprotectedId is null)
				return NotFound();

			var query = await _BookService.GetByIdAsync(unprotectedId.Value);
			query.Id = id;

			foreach (var item in query.BookCopies)
				item.Id = _dataProtector.Protect(item.Id);

			return View(query);
		}

		[Authorize(Roles = DefaultRole.Admin)]
		public async Task<ActionResult> CreateForm()
		{
			var bookVm = await GetCreateBookViewModel();

			return View(bookVm);
		}

		[HttpPost]
        [Authorize(Roles = DefaultRole.Admin)]
        public async Task<ActionResult> Create(CreateBookViewModel model)
		{
			await CheckImage(model);

			if (!ModelState.IsValid)
			{
				model = await GetCreateBookViewModel(model);

				return View(nameof(CreateForm),model);
			}

		    await _BookService.CreateAsync(model);

			TempData["successmessage"] = "Book Added Successfully";

			return RedirectToAction(nameof(Index));
		}

        [Authorize(Roles = DefaultRole.Admin)]
        public async Task<IActionResult> Edit(string id)
		{
			var unprotectedId = UnProtectedId(id);

			if (unprotectedId is null)
				return NotFound();

			var Book = await _BookService.GetByIdAsync(unprotectedId.Value);
            Book.Id = id;

			var Authors = await _AuthorService.GetAllAsync();

			var categories = await _CategoryService.GetAllAsync();

			Book.Authors = _mapper.Map<IList<SelectListItem>>(Authors);
			Book.CategoriesList = _mapper.Map<IList<SelectListItem>>(categories);

            return View(Book);
		}

		[HttpPost("Books/Edit/{id}")]
        [Authorize(Roles = DefaultRole.Admin)]
        public async Task<IActionResult> Edit(string id,CreateBookViewModel model)
		{
			await CheckImage(model);

			if (!ModelState.IsValid)
			{
                var authors = await _AuthorService.GetAllAsync();
                var categories = await _CategoryService.GetAllAsync();

                var bookVM = _mapper.Map<BookViewModel>(model);

				bookVM.Authors = model.Authors;
				bookVM.CategoriesList = model.Categories;

                return View(bookVM);
			}

			var unprotectedId = UnProtectedId(id);

			if (unprotectedId is null)
				return NotFound();

			await _BookService.UpdateAsync(unprotectedId.Value, model);

			TempData["successmessage"] = "Book Updated Successfully";

			return RedirectToAction(nameof(Index));
		}

        [Authorize(Roles = DefaultRole.Admin)]
        public async Task<IActionResult> DeleteForm(string id)
		{
			var unprotectedId = UnProtectedId(id);

			if (unprotectedId is null)
				return NotFound();

			var Book = await _BookService.GetByIdAsync(unprotectedId.Value);
			Book.Id = id;

			return View(Book);
		}

        [Authorize(Roles = DefaultRole.Admin)]
        [HttpPost("Books/Delete/{id}")]
		[IgnoreAntiforgeryToken]
		public async Task<IActionResult> Delete(string id)
		{
			var unprotectedId = UnProtectedId(id);

			if (unprotectedId is null)
				return NotFound();

			await _BookService.DeleteAsync(unprotectedId.Value);

			TempData["successmessage"] = "Book Deleted Successfully";

			return RedirectToAction(nameof(Index));
		}

		private async Task<CreateBookViewModel> GetCreateBookViewModel(CreateBookViewModel? model = null)
		{
			CreateBookViewModel viewModel = model is null ? new CreateBookViewModel() : model;

			var authors = await _AuthorService.GetAllAsync();
			var categories = await _CategoryService.GetAllAsync();

			viewModel.Authors = _mapper.Map<IList<SelectListItem>>(authors);
			viewModel.Categories = _mapper.Map<IList<SelectListItem>>(categories);

			return viewModel;
		}

		private async Task<ActionResult> CheckImage(CreateBookViewModel model)
		{
			if (model.ImageUrl is not null)
			{
				if (!_extensions.Contains(Path.GetExtension(model.ImageUrl.FileName)))
				{
					ModelState.AddModelError("ImageExtension", ".jpg,.png,.jpeg are allowed only.");

					model = await GetCreateBookViewModel(model);

					return View(nameof(CreateForm), model);
				}

				if (model.ImageUrl.Length > _MaxSize)
				{
					ModelState.AddModelError("ImageSize", "Size of Image must't be greater than 2Mb .");

					model = await GetCreateBookViewModel(model);

					return View(nameof(CreateForm), model);
				}
			}

			return null!;
		}

		private int? UnProtectedId(string id)
		{
			int protectedId;

			try
			{
				protectedId = int.Parse(_dataProtector.Unprotect(id));

				return protectedId;
			}
			catch 
			{
				return null;
			}
		}
	}
}
