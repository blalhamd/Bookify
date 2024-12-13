namespace Bookify.Presentation.Controllers
{
	[Authorize]
	public class CategoriesController : Controller
	{
		private readonly ICategoryService _CategoryService;
		private readonly IDataProtector _DataProtector;

        public CategoriesController(ICategoryService categoryService, IDataProtectionProvider dataProtector)
        {
            _CategoryService = categoryService;
			_DataProtector = dataProtector.CreateProtector(purpose: "MySecure");
        }

		[HttpGet]
        public async Task<ActionResult<IList<CategoryViewModel>>> Index()
		{
			var query = await _CategoryService.GetAllAsync();

			foreach (var item in query)
			{
				item.Id = _DataProtector.Protect(item.Id);
			}

			return View(query);
		}

		[HttpGet("Categories/Details/{id}")]
		public async Task<ActionResult<CategoryViewModel>> Details(string id)
		{
			int unprotectedId;

			try
			{
				unprotectedId = int.Parse(_DataProtector.Unprotect(id));
			}
			catch
			{
				return NotFound();
			}

            var query = await _CategoryService.GetByIdAsync(unprotectedId);
			query.Id = id; // Keep the protected ID for the view

			return View(query);
		}

		[Authorize(Roles = DefaultRole.Admin)]
		public IActionResult CreateForm()
		{
			return View();
		}

		[HttpPost]
		[Authorize(Roles = DefaultRole.Admin)]
		public async Task<ActionResult> Create(CreateCategoryRequest request)
		{
			if(!ModelState.IsValid)
			{
				return View(request);
			}

		    var id = await _CategoryService.CreateAsync(request);

			TempData["SuccessMessage"] = "Category Added Successfully";

			var protectedId = _DataProtector.Protect(id.ToString());

			return RedirectToAction(nameof(Details), new { id = protectedId });
		}

		[Authorize(Roles = DefaultRole.Admin)]
		public async Task<IActionResult> Edit(string id)
		{
			int unprotectedId;

			try
			{
				unprotectedId = int.Parse(_DataProtector.Unprotect(id));
			}
			catch
			{
				return NotFound();
			}

            var category = await _CategoryService.GetByIdAsync(unprotectedId);
			category.Id = id; // // Keep the protected ID for the view

			return View(category);
		}

		[HttpPost("Categories/Edit/{id}")]
		[Authorize(Roles = DefaultRole.Admin)]
		public async Task<IActionResult> Edit(string id,CreateCategoryRequest request)
		{
			if (!ModelState.IsValid)
			{
				return View(request);
			}

			int unprotectedId;

			try
			{
				unprotectedId = int.Parse(_DataProtector.Unprotect(id));
			}
			catch
			{
				return NotFound();
			}

            var subscriberId = await _CategoryService.UpdateAsync(unprotectedId, request);

			TempData["SuccessMessage"] = "Category Updated Successfully";

			return RedirectToAction(nameof(Details), new { id });
		}

		[Authorize(Roles = DefaultRole.Admin)]
		public async Task<IActionResult> DeleteForm(string id)
		{
			int unprotectedId;

			try
			{
				unprotectedId = int.Parse(_DataProtector.Unprotect(id));
			}
			catch
			{
				return NotFound();
			}

			var category = await _CategoryService.GetByIdAsync(unprotectedId);

			return View(category);
		}

		[HttpPost("Categories/Delete/{id}")]
		[Authorize(Roles = DefaultRole.Admin)]
		[IgnoreAntiforgeryToken]
		public async Task<IActionResult> Delete(string id)
		{
			int unprotectedId;

			try
			{
				unprotectedId = int.Parse(_DataProtector.Unprotect(id));
			}
			catch
			{
				return NotFound();
			}

			await _CategoryService.DeleteAsync(unprotectedId);

			return RedirectToAction(nameof(Index));
		}

		public async Task<ActionResult<bool>> AllowItem(CreateCategoryRequest request)
		{
			var isExist = await _CategoryService.IsExist(request.Name);

			return Json(!isExist);
		}
	}
}
