using Bookify.Core.IServices;
using Bookify.Core.ViewModels.Category.Requests;
using Bookify.Core.ViewModels.Category.Responses;

namespace Bookify.Controllers
{
	public class CategoryController : Controller
	{
		private readonly ICategoryService _CategoryService;

		public CategoryController(ICategoryService categoryService)
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
		public async Task<ActionResult> Create(CreateCategoryRequest request)
		{
		    await _CategoryService.CreateAsync(request);

			return RedirectToAction("Index");
		}
	}
}
