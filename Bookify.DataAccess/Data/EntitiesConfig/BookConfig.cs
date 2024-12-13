namespace Bookify.DataAccess.Data.EntitiesConfig
{
	public class BookConfig : IEntityTypeConfiguration<Book>
	{
		public void Configure(EntityTypeBuilder<Book> builder)
		{
			builder.ToTable("Books").HasKey(x => x.Id);

			builder.HasIndex(x => new { x.Title, x.AuthorId }).IsUnique();

			builder.Property(x => x.Type).HasConversion
				(
					x => x.ToString(),
				   	x => (BookType)Enum.Parse(typeof(BookType), x)
				);

			builder.HasData(SeedData.LoadBooks());
		}
	}
}
