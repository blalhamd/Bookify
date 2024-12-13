namespace Bookify.Core.AutoMapper
{
	public class MappingProfile : Profile
	{
        public MappingProfile()
        {
			// Authors

			CreateMap<Author, AuthorViewModel>().ReverseMap();
			CreateMap<CreateAuthorViewModel, Author>().ReverseMap();

			CreateMap<AuthorViewModel, SelectListItem>()
				.ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.Id))
				.ForMember(dest => dest.Text, opt => opt.MapFrom(src => src.Name));

			// Books

			CreateMap<Book, BookViewModel>()
				.ForMember(dest => dest.AuthorName,opt =>opt.MapFrom(src=> src.Author.Name))
				.ForMember(dest => dest.SelectedCategories, opt => opt.MapFrom(src => src.Categories.Select(x => x.Category.Name).ToList()))
				.ForMember(dest => dest.BookCopies, opt => opt.MapFrom(src => src.Copies.Select(x => new BookCopyViewModel
				{
					Title = x.Book.Title,
					Id = x.Id.ToString(),
					EditionNumber = x.EditionNumber,
					IsAvailableForRental = x.IsAvailableForRental,
					SerialNumber = x.SerialNumber
				})
				.ToList()))
				.ReverseMap();
			
			CreateMap<CreateBookViewModel, BookViewModel>()
				.ReverseMap();

			CreateMap<Book,BookViewModel>().ReverseMap();

			CreateMap<CreateBookViewModel, Book>()
				.ForMember(dest=> dest.Categories,opt=>opt.MapFrom(src=> src.SelectedCategories.Select(x=> new BookCategory
				{
					CategoryId = x
				})
				.ToList()
				))
				.ReverseMap();

			CreateMap<BookViewModel, SelectListItem>()
				.ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.Id))
				.ForMember(dest => dest.Text, opt => opt.MapFrom(src => src.Title)).ReverseMap();

			// BookCopy

			CreateMap<BookCopy, BookCopyViewModel>()
				.ForMember(dest => dest.Title, opt => opt.MapFrom(src => src.Book.Title));

			CreateMap<CreateBookCopyViewModel, BookCopy>().ReverseMap();

			// Categories

			CreateMap<Category, CategoryViewModel>().ReverseMap();

            CreateMap<CreateCategoryRequest, Category>().ReverseMap();

            CreateMap<CategoryViewModel, SelectListItem>()
				.ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.Id))
				.ForMember(dest => dest.Text, opt => opt.MapFrom(src => src.Name));


			// Users

			CreateMap<CreateUserViewModel, AppUser>()
				.ReverseMap();

            CreateMap<UserViewModel, AppUser>()
                .ReverseMap();

            CreateMap<UserViewModel, CreateUserViewModel>()
                .ReverseMap();

			// Subscriber

			CreateMap<SubscriberRequestViewModel, Subscriber>().ReverseMap();

			CreateMap<Subscriber, SubscriberViewModel>()
				.ForMember(dest => dest.AreaName, opt => opt.MapFrom(src => src.Area!.Name))
				.ForMember(dest => dest.GovernorateName, opt => opt.MapFrom(src => src.Governorate!.Name))
				.ReverseMap();

			CreateMap<SubscriberViewModel, SubscriberRequestViewModel>().ReverseMap();

			// Subscription

			CreateMap<Subscription, SubscriptionViewModel>().ReverseMap();

			// Area

			CreateMap<Area, AreaViewModel>().ReverseMap();
           
			CreateMap<AreaViewModel, SelectListItem>()
            .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.Id))
            .ForMember(dest => dest.Text, opt => opt.MapFrom(src => src.Name))
            .ReverseMap();

            // Governorate

            CreateMap<Governorate, GovernorateViewModel>().ReverseMap();

			CreateMap<GovernorateViewModel, SelectListItem>()
				.ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.Id))
				.ForMember(dest => dest.Text, opt => opt.MapFrom(src => src.Name))
				.ReverseMap();

			// Rental

			CreateMap<Rental, RentalViewModel>().ReverseMap();

			// RentalCopy
			
			CreateMap<RentalCopy, RentalCopyViewModel>().ReverseMap();

			
        }
    }
}
