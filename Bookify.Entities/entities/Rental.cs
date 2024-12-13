namespace Bookify.Entities.entities
{
	public class Rental : BaseEntity
    {
        public int SubscriberId { get; set; }
        public Subscriber? Subscriber { get; set; } 
        public DateTime StartDate { get; set; } = DateTime.Today;
        public bool PenaltyPaid { get; set; }
        public ICollection<RentalCopy> rentalCopies { get; set; } = new List<RentalCopy>();
    }
}
