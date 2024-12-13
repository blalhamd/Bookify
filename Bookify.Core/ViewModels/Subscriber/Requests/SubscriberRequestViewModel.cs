namespace Bookify.Core.ViewModels.Subscriber.Requests
{
    public class SubscriberRequestViewModel
    {
        [Required]
        public string FirstName { get; set; } = null!;

        [Required]
        public string LastName { get; set; } = null!;

        [Required]
        public string Phone { get; set; } = null!;

        [Required]
        public string Email { get; set; } = null!;

        [Required]
        public string Gender { get; set; } = null!;

        [Required]
        public DateTime DateOfBirth { get; set; }

        [Required]
        public string NationalId { get; set; } = null!;

        [Required]
        public bool HasWhatsApp { get; set; }

        [Required]
        public IFormFile ImageUrl { get; set; } = null!;

        [Required]
        [Range(1,int.MaxValue,ErrorMessage = Errors.Area)]
        public int AreaId { get; set; }
        public IList<SelectListItem>? Areas { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = Errors.Governorate)]
        public int GovernorateId { get; set; }
        public IList<SelectListItem>? Governorate { get; set; }

        [Required]
        public string Address { get; set; } = null!;

        [Required]
        public bool IsBlackListed { get; set; }
    }
}
