namespace Bookify.Business.Services
{
	public class SubscriberService : ISubscriberService
    {

        private readonly IUnitOfWorkAsync _unitOfWork;
		private readonly IImageService _ImageService;
        private readonly IEmailSender _EmailSender;
        private readonly IEmailBodyBuilder _EmailBodyBuilder;
		private readonly IMapper _mapper;

		public SubscriberService(IUnitOfWorkAsync unitOfWork, IImageService imageService, IMapper mapper, IEmailSender emailSender, IEmailBodyBuilder emailBodyBuilder)
		{
			_unitOfWork = unitOfWork;
			_ImageService = imageService;
			_mapper = mapper;
			_EmailSender = emailSender;
			_EmailBodyBuilder = emailBodyBuilder;
		}

		public async Task<IList<SubscriberViewModel>> GetAllAsync()
        {
            var subscribers = await _unitOfWork._SubscriberRepositoryAsync.GetAllAsync(["Area", "Governorate"]);

            if (subscribers == null)
                throw new Exception();

            var models = _mapper.Map<IList<SubscriberViewModel>>(subscribers);

            return models;
        }

        public async Task<SubscriberViewModel> GetByIdAsync(int id)
        {
            var subscriber = await _unitOfWork._SubscriberRepositoryAsync.GetByIdAsync(id,["Area", "Governorate", "subscriptions", "Rentals", "Rentals.rentalCopies"]);

            if (subscriber == null)
                throw new Exception();

            var model = _mapper.Map<SubscriberViewModel>(subscriber);

            return model;
        }

        public async Task<int> CreateAsync(SubscriberRequestViewModel model)
        {
            if(model is null)
                throw new ArgumentNullException("model is null");

            var subscriber = _mapper.Map<Subscriber>(model);

            var image = await _ImageService.getUniqueNameFile(model.ImageUrl!);
            subscriber.ImageUrl = image;

            // Add Subscription "Year" to Subscriber..

            Subscription subscription = new()
            {
                StartDate = DateTime.Today,
                EndDate = DateTime.Today.AddYears(1),
            };

            subscriber.subscriptions.Add(subscription); 

			await _unitOfWork._SubscriberRepositoryAsync.AddAsync(subscriber);
            await _unitOfWork.Save();

            return subscriber.Id;
        }

        public async Task<int> UpdateAsync(int id, SubscriberRequestViewModel model)
        {
            var subscriber = await _unitOfWork._SubscriberRepositoryAsync.GetByIdAsync(id);

            if (subscriber == null)
                throw new Exception();

            var oldPath = subscriber.ImageUrl;

            var updatedSubscriber = _mapper.Map(source: model,destination: subscriber);

            updatedSubscriber.ImageUrl = await _ImageService.getUniqueNameFile(model.ImageUrl!, true, oldPath!);

            await _unitOfWork._SubscriberRepositoryAsync.UpdateAsync(updatedSubscriber);
            await _unitOfWork.Save();

            return updatedSubscriber.Id;
        }

        public async Task DeleteAsync(int id)
        {
            var subscriber = await _unitOfWork._SubscriberRepositoryAsync.GetByIdAsync(id);

            if (subscriber == null)
                throw new Exception();

            subscriber.IsDeleted = !subscriber.IsDeleted;

            await _unitOfWork._SubscriberRepositoryAsync.UpdateAsync(subscriber);
            await _unitOfWork.Save();
        }

		public async Task RenewSubscription(int subscriberId)
		{
			var subscriber = await _unitOfWork._SubscriberRepositoryAsync.GetByIdAsync(subscriberId, ["subscriptions"]);

			if (subscriber == null)
				throw new ItemNotFound();

            var lastSubscription = subscriber.subscriptions.LastOrDefault();

            Subscription subscription = new();

			if (lastSubscription is not null)
			{

				var startDate = lastSubscription.EndDate < DateTime.Today ? DateTime.Today :
								lastSubscription.EndDate.AddDays(1);

                subscription.StartDate = startDate;
                subscription.EndDate = startDate.AddYears(1);
            }
			else
			{
				subscription.StartDate = DateTime.Today;
				subscription.EndDate = DateTime.Today.AddYears(1);
			}

			subscriber.subscriptions.Add(subscription);

			await _unitOfWork._SubscriberRepositoryAsync.UpdateAsync(subscriber);
			await _unitOfWork.Save();

            // TODO: Send Email

            var body = await _EmailBodyBuilder.GenerateEmailBody(
                templateName: "RenewTemp.html",
                imageUrl: "",
                header: $"Hi, {subscriber.FirstName}",
                body: "you added a new year for subscribtion with us,thaks for you!",
                link: "#",
                linkTitle: "");

            await _EmailSender.SendEmailAsync("blalsy681@gmail.com", "✅ Bookify.com", body);
		}

        public async Task<int> Count()
        {
            var count = await _unitOfWork._SubscriberRepositoryAsync.CountAsync();

            return count;
        }

		public async Task<IList<GroupedSubscriber>> GetSubscriberDashboard()
		{
            var subscribers = await _unitOfWork._SubscriberRepositoryAsync.GetSubscriberDashboard();

            if (subscribers is null)
                return new List<GroupedSubscriber>(); // as empty

            return subscribers;
		}
	}
}
