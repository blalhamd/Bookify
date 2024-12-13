namespace Bookify.Business.Services
{
	public class BookService : IBookService
	{
		private readonly IUnitOfWorkAsync _unitOfWork;
		private readonly IImageService _ImageService;
		private readonly IMapper _mapper;

		public BookService(IUnitOfWorkAsync unitOfWork, IImageService imageService, IMapper mapper)
		{
			_unitOfWork = unitOfWork;
			_ImageService = imageService;
			_mapper = mapper;
		}

		public async Task<IList<BookViewModel>> GetAllAsync()
		{
			var books = await _unitOfWork._BookRepositoryAsync.GetAllAsync(["Author", "Categories.Category"]);

			if (books is null)
				throw new Exception();

			var categoriesVm = _mapper.Map<IList<BookViewModel>>(books);

			return categoriesVm;
		}

		public async Task<BookViewModel> GetByIdAsync(int id)
		{
			var Book = await _unitOfWork._BookRepositoryAsync.GetByIdAsync(id, ["Author", "Copies", "Categories.Category"]);

			if (Book is null)
				throw new Exception();

			var BookVm = _mapper.Map<BookViewModel>(Book);

			return BookVm;
		}

		public async Task CreateAsync(CreateBookViewModel model)
		{
			var Book = _mapper.Map<Book>(model);

			var image = await _ImageService.getUniqueNameFile(model.ImageUrl!);
			Book.ImageUrl = image;

			await _unitOfWork._BookRepositoryAsync.AddAsync(Book);
			await _unitOfWork.Save();
		}
		
		public async Task UpdateAsync(int id, CreateBookViewModel model)
		{
			var existingBook = await _unitOfWork._BookRepositoryAsync.GetByIdAsync(id, ["Categories.Category"]);

			if (existingBook is null)
				throw new Exception();

			var oldPath = existingBook.ImageUrl;

			var updatedBook = _mapper.Map(model, existingBook);

			updatedBook.ImageUrl = await _ImageService.getUniqueNameFile(model.ImageUrl!, true, oldPath!);

			await _unitOfWork._BookRepositoryAsync.UpdateAsync(updatedBook);
			await _unitOfWork.Save();
		}

		public async Task DeleteAsync(int id)
		{
			var Book = await _unitOfWork._BookRepositoryAsync.GetByIdAsync(id);

			if (Book is null)
				throw new Exception();

			var oldPath = Book.ImageUrl;

			await _ImageService.getUniqueNameFile(true, oldPath!);
			await _unitOfWork._BookRepositoryAsync.DeleteAsync(Book);
			await _unitOfWork.Save();
		}

		public async Task<IList<BookViewModel>?> GetLastEightBooks()
		{
			var query = await _unitOfWork._BookRepositoryAsync.GetLastEightBooks();

			if (query is null)
				return null!;

			var bookModels = _mapper.Map<IList<BookViewModel>>(query);

			return bookModels!;
        }

        public async Task<IList<BookSearchResult>> FindAsync(string searchTerm)
        {
			var books = await _unitOfWork._BookRepositoryAsync.FindAsync(searchTerm);

			if(books is null)
				return new List<BookSearchResult>(); // as empty

			return books;
        }
    }
}
