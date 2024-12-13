namespace Bookify.Entities.entities
{
	public class BookCopy : BaseEntity
	{
        public int BookId { get; set; }
        public Book Book { get; set; } = null!;
        public bool IsAvailableForRental { get; set; }
        public int EditionNumber { get; set; }
        public int SerialNumber { get; set; } // UNIQUE and will Generate by Sequence in SQL Server..
		public ICollection<RentalCopy> rentalCopies { get; set; } = new List<RentalCopy>();
	}
}
