namespace Bookify.Core.ViewModels.Rental.Responses
{
	public class RentalViewModel
	{
        public int Id { get; set; }
		public SubscriberViewModel? Subscriber { get; set; }
		public DateTime StartDate { get; set; } = DateTime.Today;
		public bool PenaltyPaid { get; set; }
		public IList<RentalCopyViewModel> rentalCopies { get; set; } = new List<RentalCopyViewModel>();

        public int TotalDeleyInRentalCopies
		{
			get
			{
				return rentalCopies.Sum(r => r.DelayInDays);
			}
		}
		public int NumberOfRentalCopies
		{
			get
			{
				return rentalCopies.Count();
			}
		}
	}
}
