namespace Bookify.Entities.entities
{
	public class Subscription : BaseEntity
    {
        public int SubscriberId { get; set; }
        public Subscriber Subscriber { get; set; } = null!;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
