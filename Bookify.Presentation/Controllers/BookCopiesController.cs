namespace Bookify.Presentation.Controllers
{
	[Authorize]
	public class BookCopiesController : Controller
	{
		private readonly IBookCopyService _BookCopyService;
		private readonly IBookService _bookService;
		private readonly IMapper _mapper;
		private readonly IDataProtector _dataProtector;
		public BookCopiesController(IBookCopyService BookCopyService, IBookService bookService, IMapper mapper, IDataProtectionProvider dataProtector)
		{
			_BookCopyService = BookCopyService;
			_bookService = bookService;
			_mapper = mapper;
			_dataProtector = dataProtector.CreateProtector(purpose: "MySecureIds");
		}

		[HttpGet]
		public async Task<ActionResult<IList<BookCopyViewModel>>> Index()
		{
			var query = await _BookCopyService.GetAllAsync();

			foreach (var item in query)
				item.Id = _dataProtector.Protect(item.Id);

			return View(query);
		}

		[HttpGet("BookCopies/Details/{id}")]
		public async Task<ActionResult<BookCopyViewModel>> Details(string id)
		{
			var unprotectedId = UnprotectId(id);

			if (unprotectedId == null)
				return NotFound();

			var query = await _BookCopyService.GetByIdAsync(unprotectedId.Value);
			query.Id = id; // Keep on Protected Id

			return View(query);
		}

		[Authorize(Roles = DefaultRole.Admin)]
		public async Task<ActionResult> CreateForm(string BookId)
		{
			var unprotectedId = UnprotectId(BookId);

			if (unprotectedId == null)
				return NotFound();

			var book = await _bookService.GetByIdAsync(unprotectedId.Value);

			var model = new CreateBookCopyViewModel
			{
				BookId = unprotectedId.Value,
				ShowForRental = book.IsAvailableForRental
			};

			return View(model);
		}

		[HttpPost]
		[Authorize(Roles = DefaultRole.Admin)]
		public async Task<ActionResult> Create(CreateBookCopyViewModel request)
		{
			if (!ModelState.IsValid)
			{
				return View(request);
			}

			var id = await _BookCopyService.CreateAsync(request);

			TempData["successmessage"] = "Copy Added Successfully";

			var protectedId = _dataProtector.Protect(id.ToString());

			return RedirectToAction("Details", "Books",new { id = protectedId });
		}

		public async Task<IActionResult> Edit(string id)
		{
			var unprotectedId = UnprotectId(id);

			if (unprotectedId == null)
				return NotFound();

			var BookCopy = await _BookCopyService.GetByIdAsync(unprotectedId.Value);
			BookCopy.Id = id;

			return View(BookCopy);
		}

		[HttpPost("BookCopies/Edit/{id}")]
		[Authorize(Roles = DefaultRole.Admin)]
		public async Task<IActionResult> Edit(string id, CreateBookCopyViewModel request)
		{
			if (!ModelState.IsValid)
			{
				return View(request);
			}

			var unprotectedId = UnprotectId(id);

			if (unprotectedId == null)
				return NotFound();

			var bookId = await _BookCopyService.UpdateAsync(unprotectedId.Value, request);

			TempData["successmessage"] = "Book Updated Successfully";

			return RedirectToAction("Details", "Books", new { id  });
		}

		[Authorize(Roles = DefaultRole.Admin)]
		public async Task<IActionResult> DeleteForm(string id)
		{
			var unprotectedId = UnprotectId(id);

			if (unprotectedId == null)
				return NotFound();

			var BookCopy = await _BookCopyService.GetByIdAsync(unprotectedId.Value);
			BookCopy.Id = id;

			return View(BookCopy);
		}

		[HttpPost("BookCopies/Delete/{id}")]
		[Authorize(Roles = DefaultRole.Admin)]
		[IgnoreAntiforgeryToken]
		public async Task<IActionResult> Delete(string id)
		{
			var unprotectedId = UnprotectId(id);

			if (unprotectedId == null)
				return NotFound();

			await _BookCopyService.DeleteAsync(unprotectedId.Value);

			TempData["successmessage"] = "Status Toggled Successfully";

			return RedirectToAction(nameof(Index),"Books");
		}

		private int? UnprotectId(string protectedId)
		{
			try
			{
				return int.Parse(_dataProtector.Unprotect(protectedId));
			}
			catch
			{
				return null; // Return null for invalid IDs
			}
		}
	}
}
