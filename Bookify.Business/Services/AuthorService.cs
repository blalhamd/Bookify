namespace Authorify.Business.Services
{
	public class AuthorService : IAuthorService
	{
		private readonly IUnitOfWorkAsync _unitOfWork;
		private readonly IMapper _mapper;
		public AuthorService(IUnitOfWorkAsync unitOfWork, IMapper mapper)
		{
			_unitOfWork = unitOfWork;
			_mapper = mapper;
		}

		public async Task<IList<AuthorViewModel>> GetAllAsync()
		{
			var categories = await _unitOfWork._AuthorRepositoryAsync.GetAllAsync();

			if (categories is null)
				throw new Exception();

			var categoriesVm = _mapper.Map<IList<AuthorViewModel>>(categories);

			return categoriesVm;
		}

		public async Task<AuthorViewModel> GetByIdAsync(int id)
		{
			var Author = await _unitOfWork._AuthorRepositoryAsync.GetByIdAsync(id);

			if (Author is null)
				throw new Exception();

			var AuthorVm = _mapper.Map<AuthorViewModel>(Author);

			return AuthorVm;
		}

		public async Task CreateAsync(CreateAuthorViewModel model)
		{
			var Author = _mapper.Map<Author>(model);

			await _unitOfWork._AuthorRepositoryAsync.AddAsync(Author);
			await _unitOfWork.Save();
		}
		
		public async Task UpdateAsync(int id, CreateAuthorViewModel model)
		{
			var Author = await _unitOfWork._AuthorRepositoryAsync.GetByIdAsync(id);

			if (Author is null)
				throw new Exception();

			Author.Name = model.Name;

			await _unitOfWork._AuthorRepositoryAsync.UpdateAsync(Author);
			await _unitOfWork.Save();
		}

		public async Task DeleteAsync(int id)
		{
			var Author = await _unitOfWork._AuthorRepositoryAsync.GetByIdAsync(id);

			if (Author is null)
				throw new Exception();

			await _unitOfWork._AuthorRepositoryAsync.DeleteAsync(Author);
			await _unitOfWork.Save();
		}

	}
}
