namespace Bookify.Entities.entities
{
    public class Subscriber : BaseEntity
	{
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Gender { get; set; } = null!;
        public DateTime DateOfBirth { get; set; }
        public string NationalId { get; set; } = null!;
        public bool HasWhatsApp { get; set; }
        public string ImageUrl { get; set; } = null!;
        public int AreaId { get; set; }
        public Area? Area { get; set; } = null!;
        public int GovernorateId { get; set; }
        public Governorate? Governorate { get; set; } = null!;
        public string Address { get; set; } = null!;
        public bool IsBlackListed { get; set; }
        public ICollection<Subscription> subscriptions { get; set; } = new List<Subscription>();
        public ICollection<Rental> Rentals { get; set; } = new List<Rental>();
    }
}
