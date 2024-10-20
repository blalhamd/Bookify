namespace Bookify.DataAccess.Data.EntitiesConfig
{
	public class AuthorConfig : IEntityTypeConfiguration<Author>
	{
		public void Configure(EntityTypeBuilder<Author> builder)
		{
			builder.ToTable("Authors").HasKey(x => x.Id);

			builder.HasData(SeedData.LoadAuthors());
		}
	}
}
