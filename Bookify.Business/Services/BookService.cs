namespace Bookify.Business.Services
{
	public class BookService : IBookService
	{
		private readonly IUnitOfWorkAsync _unitOfWork;
		private readonly IMapper _mapper;
		public BookService(IUnitOfWorkAsync unitOfWork, IMapper mapper)
		{
			_unitOfWork = unitOfWork;
			_mapper = mapper;
		}

		public async Task<IList<BookViewModel>> GetAllAsync()
		{
			var categories = await _unitOfWork._BookRepositoryAsync.GetAllAsync();

			if (categories is null)
				throw new Exception();

			var categoriesVm = _mapper.Map<IList<BookViewModel>>(categories);

			return categoriesVm;
		}

		public async Task<BookViewModel> GetByIdAsync(int id)
		{
			var Book = await _unitOfWork._BookRepositoryAsync.GetByIdAsync(id);

			if (Book is null)
				throw new Exception();

			var BookVm = _mapper.Map<BookViewModel>(Book);

			return BookVm;
		}

		public async Task CreateAsync(CreateBookViewModel model)
		{
			var Book = _mapper.Map<Book>(model);

			await _unitOfWork._BookRepositoryAsync.AddAsync(Book);
			await _unitOfWork.Save();
		}
		
		public async Task UpdateAsync(int id, CreateBookViewModel model)
		{
			var book = await _unitOfWork._BookRepositoryAsync.GetByIdAsync(id);

			if (book is null)
				throw new Exception();

			book.Title = model.Title;
			book.Description = model.Description;
			book.Price = model.Price;
			book.AuthorId = model.AuthorId;
			book.Publisher = model.Publisher;
			book.PublishedOn = model.PublishedOn;
			book.Hall = model.Hall;
			book.ImageUrl = model.ImageUrl;
			book.IsAvailableForRental = model.IsAvailableForRental;

			await _unitOfWork._BookRepositoryAsync.UpdateAsync(book);
			await _unitOfWork.Save();
		}

		public async Task DeleteAsync(int id)
		{
			var Book = await _unitOfWork._BookRepositoryAsync.GetByIdAsync(id);

			if (Book is null)
				throw new Exception();

			await _unitOfWork._BookRepositoryAsync.DeleteAsync(Book);
			await _unitOfWork.Save();
		}

	}
}
