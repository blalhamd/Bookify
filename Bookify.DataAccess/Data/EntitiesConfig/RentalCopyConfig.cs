namespace Bookify.DataAccess.Data.EntitiesConfig
{
	public class RentalCopyConfig : IEntityTypeConfiguration<RentalCopy>
	{
		public void Configure(EntityTypeBuilder<RentalCopy> builder)
		{
			builder.ToTable("RentalCopies").HasKey(x => new { x.RentalId, x.BookCopyId });
		}
	}
}
