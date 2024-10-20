namespace Bookify.Controllers
{
	public class CategoriesController : Controller
	{
		private readonly ICategoryService _CategoryService;

		public CategoriesController(ICategoryService categoryService)
		{
			_CategoryService = categoryService;
		}

		public async Task<ActionResult<IList<CategoryViewModel>>> Index()
		{
			var query = await _CategoryService.GetAllAsync();

			return View(query);
		}

		public async Task<ActionResult<CategoryViewModel>> Details(int id)
		{
			var query = await _CategoryService.GetByIdAsync(id);

			return View(query);
		}

		public IActionResult CreateForm()
		{
			return View();
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<ActionResult> Create(CreateCategoryRequest request)
		{
			if(!ModelState.IsValid)
			{
				return View(request);
			}

		    await _CategoryService.CreateAsync(request);

			return RedirectToAction(nameof(Index));
		}

		public async Task<IActionResult> Edit(int id)
		{
			var category = await _CategoryService.GetByIdAsync(id);

			return View(category);
		}

		[HttpPost("Categories/Edit/{id}")]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Edit(int id,CreateCategoryRequest request)
		{
			if (!ModelState.IsValid)
			{
				return View(request);
			}

			await _CategoryService.UpdateAsync(id,request);

			return RedirectToAction(nameof(Index));
		}

		public async Task<IActionResult> DeleteForm(int id)
		{
			var category = await _CategoryService.GetByIdAsync(id);

			return View(category);
		}

		[HttpPost("Categories/Delete/{id}")]
		public async Task<IActionResult> Delete(int id)
		{
			await _CategoryService.DeleteAsync(id);

			return RedirectToAction(nameof(Index));
		}
	}
}
