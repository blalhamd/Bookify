namespace Bookify.DataAccess.Data.EntitiesConfig
{
	public class BookCopyConfig : IEntityTypeConfiguration<BookCopy>
	{
		public void Configure(EntityTypeBuilder<BookCopy> builder)
		{
			builder.ToTable("BookCopies").HasKey(x => x.Id);

			builder.Property(x => x.SerialNumber).HasDefaultValueSql("NEXT VALUE FOR Shared.SerialNumber");

			builder.HasData(SeedData.LoadCopies());
		}
	}
}
