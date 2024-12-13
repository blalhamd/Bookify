namespace Bookify.Presentation.Controllers
{
    public class SubscribersController : Controller
    {
        private readonly ISubscriberService _subscriberService;
        private readonly IAreaService _areaService;
        private readonly IGovernorateService _governorateService;
        private readonly IMapper _mapper;
        private readonly IDataProtector _dataProtector;
		public SubscribersController(ISubscriberService subscriberService,
            IAreaService areaService,
            IGovernorateService governorateService,
            IMapper mapper,
            IDataProtectionProvider dataProtector)
		{
			_subscriberService = subscriberService;
			_areaService = areaService;
			_governorateService = governorateService;
			_mapper = mapper;
            _dataProtector = dataProtector.CreateProtector(purpose: "MySecureKey");
		}

		[HttpGet]
        public async Task<IActionResult> Index()
        {
            var query = await _subscriberService.GetAllAsync();

            foreach (var item in query)
				item.Id = _dataProtector.Protect(item.Id);

			return View(query);
        }

        [HttpGet("Subscribers/GetById/{id}")]
        public async Task<IActionResult> GetById(string id)
        {
			var unprotectedId = UnProtectedId(id);

			if (unprotectedId is null)
				return NotFound();

			var subscriber = await _subscriberService.GetByIdAsync(unprotectedId.Value);
            subscriber.Id = id;

            return View(subscriber);
        }
        public async Task<IActionResult> CreateForm()
        {
            var (governatesSelectListItem, areasSelectListItem) = await GetGovernoratesAndAreas();

            var model = new SubscriberRequestViewModel
            {
                Governorate = governatesSelectListItem,
                Areas = areasSelectListItem,
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Create(SubscriberRequestViewModel model)
        {
            if (!ModelState.IsValid)
            {
                var (governatesSelectListItem, areasSelectListItem) = await GetGovernoratesAndAreas();

                model.Governorate = governatesSelectListItem;
                model.Areas = areasSelectListItem;

                return View(model);
            }

            var id = await _subscriberService.CreateAsync(model);

            TempData["successmessage"] = "Subscriber Added Successfully";

            var subscriberId = _dataProtector.Protect(id.ToString());

            return RedirectToAction(nameof(GetById), new { id = subscriberId });
        }

        public async Task<IActionResult> EditForm(string id)
        {
			var unprotectedId = UnProtectedId(id);

			if (unprotectedId is null)
				return NotFound();
            
            var model = await _subscriberService.GetByIdAsync(unprotectedId.Value);
            model.Id = id;

            var (governatesSelectListItem, areasSelectListItem) = await GetGovernoratesAndAreas();

            model.Governorates = governatesSelectListItem;
            model.Areas = areasSelectListItem;

            return View(model);
        }

        [HttpPost("Subscribers/Edit/{id}")]
        public async Task<IActionResult> Edit(string id,SubscriberRequestViewModel request)
        {
            if (!ModelState.IsValid)
            {
                var model = _mapper.Map<SubscriberViewModel>(request);

                var (governatesSelectListItem, areasSelectListItem) = await GetGovernoratesAndAreas();

                model.Governorates = governatesSelectListItem;
                model.Areas = areasSelectListItem;

                return View(model);
            }

			var unprotectedId = UnProtectedId(id);

			if (unprotectedId is null)
				return NotFound();

			var subscriberId = await _subscriberService.UpdateAsync(unprotectedId.Value, request);

            TempData["successmessage"] = "Subscriber Updated Successfully";

            return RedirectToAction(nameof(GetById), new { id });
        }

        [HttpPost("Subscribers/Delete/{id}")]
		[IgnoreAntiforgeryToken]
		public async Task<IActionResult> DeleteAsync(string id)
        {
			var unprotectedId = UnProtectedId(id);

			if (unprotectedId is null)
				return NotFound();

			await _subscriberService.DeleteAsync(unprotectedId.Value);

            TempData["successmessage"] = "Subscriber Deleted Successfully";

            return RedirectToAction(nameof(Index));
        }

        [HttpGet("Subscribers/Renew")]
        public async Task<IActionResult> RenewSubscription(string subscriberId)
        {
            var unprotectedSubscriberId = UnProtectedId(subscriberId);

            if(unprotectedSubscriberId is null)
				return NotFound();

            await _subscriberService.RenewSubscription(unprotectedSubscriberId.Value);

            return RedirectToAction(nameof(GetById), new { id = subscriberId });
		}
		private async Task<(IList<SelectListItem>? governorates, IList<SelectListItem>? areas)> GetGovernoratesAndAreas()
        {
            var governates = await _governorateService.GetAllAsync();
            var areas = await _areaService.GetAllAsync();

            var governatesSelectListItem = _mapper.Map<IList<SelectListItem>>(governates);
            var areasSelectListItem = _mapper.Map<IList<SelectListItem>>(areas);

            return (governatesSelectListItem, areasSelectListItem);
        }

		private int? UnProtectedId(string id)
		{
			int protectedId;

			try
			{
				protectedId = int.Parse(_dataProtector.Unprotect(id));

				return protectedId;
			}
			catch
			{
				return null;
			}
		}
	}
}
