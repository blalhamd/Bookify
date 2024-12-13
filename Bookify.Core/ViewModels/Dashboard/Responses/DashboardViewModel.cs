namespace Bookify.Core.ViewModels.Dashboard.Responses
{
    public class DashboardViewModel
    {
        public int SubscribersCount { get; set; }
        public int BookCopiesCount { get; set; }
        public IList<BookViewModel>? Books { get; set; } = new List<BookViewModel>();
        public IList<GroupedSubscriber> Subscribers { get; set; } = new List<GroupedSubscriber>();
    }
}
