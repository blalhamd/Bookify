namespace Bookify.Core.ViewModels.Rental.Requests
{
	public class RentalFormViewModel
	{
		public string SubscriberName { get; set; } = null!;
		public bool PenaltyPaid { get; set; }
		public IList<int> SelectedCopies { get; set; } = null!;
	}
}
