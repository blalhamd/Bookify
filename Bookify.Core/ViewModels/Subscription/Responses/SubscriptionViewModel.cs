namespace Bookify.Core.ViewModels.Subscription.Responses
{
	public class SubscriptionViewModel
	{
		public int Id { get; set; }
		public DateTime StartDate { get; set; }
		public DateTime EndDate { get; set; }
		public DateTime CreationTime { get; set; }
        public string Status
		{
			get
			{
				return DateTime.Today > EndDate ? "Expired" : StartDate > DateTime.Now ? string.Empty : "Active";
			}
		}

    }
}
