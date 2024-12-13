namespace Bookify.Business.Services
{
    public class GovernorateService : IGovernorateService
    {
        private readonly IGenericRepositoryAsync<Governorate> _genericRepository;
        private readonly IMapper _mapper;
        public GovernorateService(IGenericRepositoryAsync<Governorate> genericRepository, IMapper mapper)
        {
            _genericRepository = genericRepository;
            _mapper = mapper;
        }

        public async Task<IList<GovernorateViewModel>> GetAllAsync()
        {
            var query = await _genericRepository.GetAllAsync();

            if (query == null)
                throw new Exception();

            var models = _mapper.Map<IList<GovernorateViewModel>>(query);

            return models;
        }

        
    }
}
