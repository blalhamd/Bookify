namespace Bookify.Business.Services
{
    public class AreaService : IAreaService
    {
        private readonly IGenericRepositoryAsync<Area> _genericRepository;
        private readonly IMapper _mapper;
        public AreaService(IGenericRepositoryAsync<Area> genericRepository, IMapper mapper)
        {
            _genericRepository = genericRepository;
            _mapper = mapper;
        }

        public async Task<IList<AreaViewModel>> GetAllAsync()
        {
            var query = await _genericRepository.GetAllAsync();

            if (query == null)
                throw new Exception();

            var models = _mapper.Map<IList<AreaViewModel>>(query);

            return models;
        }


    }
}
