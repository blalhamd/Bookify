namespace Bookify.DataAccess.Data.EntitiesConfig
{
	public class BookCategoryConfig : IEntityTypeConfiguration<BookCategory>
	{
		public void Configure(EntityTypeBuilder<BookCategory> builder)
		{
			builder.ToTable("BookCategories").HasKey(x => new { x.CategoryId, x.BookId });

			builder.HasData(SeedData.LoadBookCategory());
		}
	}
}
