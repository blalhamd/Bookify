namespace Bookify.Core.ViewModels.RentalCopy.Responses
{
	public class RentalCopyViewModel
	{
		public BookCopyViewModel? BookCopy { get; set; }
		public DateTime RentalDate { get; set; } = DateTime.Today;
		public DateTime EndDate { get; set; } = DateTime.Today.AddDays((int)RentalConfig.RentalDuration);
		public DateTime? ReturndedDate { get; set; }
		public DateTime? ExtendedOn { get; set; }
		public int DelayInDays
		{
			get
			{
				int delay;

				if (ReturndedDate.HasValue && ReturndedDate.Value > EndDate)
				{
					delay = ReturndedDate.Value.Day - EndDate.Day;
				}
				else if (!ReturndedDate.HasValue && DateTime.Now > EndDate)
				{
					delay = DateTime.Now.Day - EndDate.Day;
				}
				else
				{
					delay = 0;
				}

				return delay; 
			}
		}
	}
}
