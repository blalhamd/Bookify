namespace Bookify.Core.AutoMapper
{
	public class MappingProfile : Profile
	{
        public MappingProfile()
        {
            CreateMap<Category,CategoryViewModel>().ReverseMap();
            CreateMap<CreateCategoryRequest,Category>().ReverseMap();

			CreateMap<Author, AuthorViewModel>().ReverseMap();
			CreateMap<CreateAuthorViewModel, Author>().ReverseMap();

			CreateMap<Book, AuthorViewModel>().ReverseMap();
			CreateMap<CreateAuthorViewModel, Book>().ReverseMap();
		}
    }
}
