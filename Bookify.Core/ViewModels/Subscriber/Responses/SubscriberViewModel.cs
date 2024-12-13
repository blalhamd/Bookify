namespace Bookify.Core.ViewModels.Subscriber.Responses
{
    public class SubscriberViewModel
    {
        public string Id { get; set; } = null!;
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Gender { get; set; } = null!;
        public DateTime DateOfBirth { get; set; }
        public string NationalId { get; set; } = null!;
        public bool HasWhatsApp { get; set; }
        public string ImageUrl { get; set; } = null!;
        public string AreaName { get; set; } = null!;
        public IList<SelectListItem>? Areas { get; set; }
        public string GovernorateName { get; set; } = null!;
        public IList<SelectListItem>? Governorates { get; set; }
        public string Address { get; set; } = null!;
        public bool IsBlackListed { get; set; }
        public IList<SubscriptionViewModel> subscriptions { get; set; } = null!;
        public IList<RentalViewModel> rentals { get; set; } = null!;
    }
}
