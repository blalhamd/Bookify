namespace Authorify.Business.Services
{
	public class AuthorService : IAuthorService
	{
		private readonly IUnitOfWorkAsync _unitOfWork;
		private readonly IMapper _mapper;
		private readonly ILoggerService _loggerService;
		public AuthorService(IUnitOfWorkAsync unitOfWork, IMapper mapper, ILoggerService loggerService)
		{
			_unitOfWork = unitOfWork;
			_mapper = mapper;
			_loggerService = loggerService;
		}

		public async Task<IList<AuthorViewModel>> GetAllAsync()
		{
			_loggerService.LogInfo("Fetching all authors.");

			var authors = await _unitOfWork._AuthorRepositoryAsync.GetAllAsync();

			if (authors is null)
			{
				_loggerService.LogWarning("No authors found.");
				throw new Exception();
			}

			var authorsVm = _mapper.Map<IList<AuthorViewModel>>(authors);

			_loggerService.LogInfo($"{authorsVm.Count} authors retrieved successfully.");

			return authorsVm;
		}

		public async Task<AuthorViewModel> GetByIdAsync(int id)
		{
			_loggerService.LogInfo("Fetching author with ID: {ID}.",id);

			var Author = await _unitOfWork._AuthorRepositoryAsync.GetByIdAsync(id);

			if (Author is null)
			{
				_loggerService.LogWarning("Author with ID: {id} not found.",id);
		    	throw new Exception();
			}

			var AuthorVm = _mapper.Map<AuthorViewModel>(Author);
			_loggerService.LogInfo("Author with ID: {id} retrieved successfully.", id);

			return AuthorVm;
		}

		public async Task CreateAsync(CreateAuthorViewModel model)
		{
			_loggerService.LogInfo("Creating a new author.");

			var author = _mapper.Map<Author>(model);

			await _unitOfWork._AuthorRepositoryAsync.AddAsync(author);
			await _unitOfWork.Save();

			_loggerService.LogInfo("Author created successfully with ID {0}.", author.Id);
		}

		public async Task UpdateAsync(int id, CreateAuthorViewModel model)
		{
			_loggerService.LogInfo("Updating author with ID {id}.", id);

			var existingAuthor = await _unitOfWork._AuthorRepositoryAsync.GetByIdAsync(id);

			if (existingAuthor is null)
			{
				_loggerService.LogWarning("Cannot update. Author with ID {id} not found.", id);
				throw new Exception();
			}

			var UpdatedAuthor = _mapper.Map(model, existingAuthor);

			await _unitOfWork._AuthorRepositoryAsync.UpdateAsync(UpdatedAuthor);
			await _unitOfWork.Save();

			_loggerService.LogInfo("Author with ID {0} updated successfully.", id);
		}

		public async Task DeleteAsync(int id)
		{
			_loggerService.LogInfo($"Deleting author with ID {id}.");

			var Author = await _unitOfWork._AuthorRepositoryAsync.GetByIdAsync(id);

			if (Author is null)
			{
				_loggerService.LogWarning("Cannot delete. Author with ID {id} not found.", id);

				throw new Exception();
			}

			await _unitOfWork._AuthorRepositoryAsync.DeleteAsync(Author);
			await _unitOfWork.Save();

			_loggerService.LogInfo("Author with ID {id} deleted successfully.", id);
		}

	}
}
