namespace Bookify.Business.Services
{
	public class CategoryService : ICategoryService
	{
		private readonly IUnitOfWorkAsync _unitOfWork;
		private readonly IMapper _mapper;
		public CategoryService(IUnitOfWorkAsync unitOfWork, IMapper mapper)
		{
			_unitOfWork = unitOfWork;
			_mapper = mapper;
		}

		public async Task<IList<CategoryViewModel>> GetAllAsync()
		{
			var categories = await _unitOfWork._CategoryRepositoryAsync.GetAllAsync();

			if (categories is null)
				throw new Exception();

			var categoriesVm = _mapper.Map<IList<CategoryViewModel>>(categories);

			return categoriesVm;
		}

		public async Task<CategoryViewModel> GetByIdAsync(int id)
		{
			var category = await _unitOfWork._CategoryRepositoryAsync.GetByIdAsync(id);

			if (category is null)
				throw new Exception();

			var categoryVm = _mapper.Map<CategoryViewModel>(category);

			return categoryVm;
		}

		public async Task CreateAsync(CreateCategoryRequest model)
		{
			var category = _mapper.Map<Category>(model);

			await _unitOfWork._CategoryRepositoryAsync.AddAsync(category);
			await _unitOfWork.Save();
		}
		
		public async Task UpdateAsync(int id, CreateCategoryRequest model)
		{
			var category = await _unitOfWork._CategoryRepositoryAsync.GetByIdAsync(id);

			if (category is null)
				throw new Exception();

			category.Name = model.Name;

			await _unitOfWork._CategoryRepositoryAsync.UpdateAsync(category);
			await _unitOfWork.Save();
		}

		public async Task DeleteAsync(int id)
		{
			var category = await _unitOfWork._CategoryRepositoryAsync.GetByIdAsync(id);

			if (category is null)
				throw new Exception();

			await _unitOfWork._CategoryRepositoryAsync.DeleteAsync(category);
			await _unitOfWork.Save();
		}

	}
}
