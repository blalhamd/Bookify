using AutoMapper;
using Bookify.Core.ViewModels.Category.Requests;
using Bookify.Core.ViewModels.Category.Responses;
using Bookify.Entities.entities;

namespace Bookify.Core.AutoMapper
{
	public class MappingProfile : Profile
	{
        public MappingProfile()
        {
            CreateMap<Category,CategoryViewModel>().ReverseMap();
            CreateMap<CreateCategoryRequest,Category>().ReverseMap();
        }
    }
}
