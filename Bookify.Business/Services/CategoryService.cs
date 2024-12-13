using Bookify.Shared.Exceptions;

namespace Bookify.Business.Services
{
	public class CategoryService : ICategoryService
	{
		private readonly IUnitOfWorkAsync _unitOfWork;
		private readonly IMapper _mapper;
		private readonly ILoggerService _loggerService;

		public CategoryService(IUnitOfWorkAsync unitOfWork, IMapper mapper, ILoggerService loggerService)
		{
			_unitOfWork = unitOfWork;
			_mapper = mapper;
			_loggerService = loggerService;
		}

		public async Task<IList<CategoryViewModel>> GetAllAsync()
		{
			var categories = await _unitOfWork._CategoryRepositoryAsync.GetAllAsync();

			if (categories is null)
				throw new ItemNotFound("not exist categories");

			var categoriesVm = _mapper.Map<IList<CategoryViewModel>>(categories);

			return categoriesVm;
		}

		public async Task<CategoryViewModel> GetByIdAsync(int id)
		{
			var category = await _unitOfWork._CategoryRepositoryAsync.GetByIdAsync(id);

			if (category is null)
				throw new ItemNotFound("not exist category");

			var categoryVm = _mapper.Map<CategoryViewModel>(category);

			return categoryVm;
		}

		public async Task<int> CreateAsync(CreateCategoryRequest model)
		{
			var IsCategoryExist = await IsExist(model.Name);

			if (IsCategoryExist)
				throw new Exception();

			var category = _mapper.Map<Category>(model);

			await _unitOfWork._CategoryRepositoryAsync.AddAsync(category);
			await _unitOfWork.Save();

			return category.Id;
		}
		
		public async Task<int> UpdateAsync(int id, CreateCategoryRequest model)
		{
			var existingCategory = await _unitOfWork._CategoryRepositoryAsync.GetByIdAsync(id);

			if (existingCategory is null)
				throw new Exception();

			var UpdatedCategory = _mapper.Map(model, existingCategory);

			await _unitOfWork._CategoryRepositoryAsync.UpdateAsync(UpdatedCategory);
            await _unitOfWork.Save();

            return UpdatedCategory.Id;
        }

        public async Task DeleteAsync(int id)
		{
			var category = await _unitOfWork._CategoryRepositoryAsync.GetByIdAsync(id);

			if (category is null)
				throw new Exception();

			category.IsDeleted = !category.IsDeleted;
			await _unitOfWork._CategoryRepositoryAsync.UpdateAsync(category);
			await _unitOfWork.Save();
		}

		public async Task<bool> IsExist(string Name)
		{
			return await _unitOfWork._CategoryRepositoryAsync.IsCategoryExist(Name);			
		}
	}
}
