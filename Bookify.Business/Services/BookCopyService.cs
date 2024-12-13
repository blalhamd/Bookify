namespace Bookify.Business.Services
{
	public class BookCopyService : IBookCopyService
	{
		private readonly IUnitOfWorkAsync _unitOfWork;
		private readonly IMapper _mapper;
		public BookCopyService(IUnitOfWorkAsync unitOfWork, IMapper mapper)
		{
			_unitOfWork = unitOfWork;
			_mapper = mapper;
		}

		public async Task<IList<BookCopyViewModel>> GetAllAsync()
		{
			var copies = await _unitOfWork._BookCopyRepositoryAsync.GetAllAsync();

			if (copies is null)
				throw new Exception();

			var copiesVm = _mapper.Map<IList<BookCopyViewModel>>(copies);

			return copiesVm;
		}

		public async Task<BookCopyViewModel> GetByIdAsync(int id)
		{
			var BookCopy = await _unitOfWork._BookCopyRepositoryAsync.GetByIdAsync(id);

			if (BookCopy is null)
				throw new Exception();

			var BookCopyVm = _mapper.Map<BookCopyViewModel>(BookCopy);

			return BookCopyVm;
		}

		public async Task<int> CreateAsync(CreateBookCopyViewModel model)
		{
			var BookCopy = _mapper.Map<BookCopy>(model);

			await _unitOfWork._BookCopyRepositoryAsync.AddAsync(BookCopy);
			await _unitOfWork.Save();

			return BookCopy.BookId;
		}

		public async Task<int> UpdateAsync(int id, CreateBookCopyViewModel model)
		{
			var existingBookCopy = await _unitOfWork._BookCopyRepositoryAsync.GetByIdAsync(id);

			if (existingBookCopy is null)
				throw new Exception();

			var UpdatedBookCopy = _mapper.Map(model, existingBookCopy);

			await _unitOfWork._BookCopyRepositoryAsync.UpdateAsync(UpdatedBookCopy);
			await _unitOfWork.Save();

			return UpdatedBookCopy.BookId;
		}

		public async Task DeleteAsync(int id)
		{
			var BookCopy = await _unitOfWork._BookCopyRepositoryAsync.GetByIdAsync(id);

			if (BookCopy is null)
				throw new Exception();

			BookCopy.IsDeleted = !BookCopy.IsDeleted;

			await _unitOfWork._BookCopyRepositoryAsync.UpdateAsync(BookCopy);
			await _unitOfWork.Save();
		}

        public async Task<int> Count()
        {
            var count = await _unitOfWork._BookCopyRepositoryAsync.CountAsync();

            return count;
        }
    }
}
