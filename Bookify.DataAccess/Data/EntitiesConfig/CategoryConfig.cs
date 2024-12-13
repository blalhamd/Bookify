namespace Bookify.DataAccess.Data.EntitiesConfig
{
	public class CategoryConfig : IEntityTypeConfiguration<Category>
	{
		public void Configure(EntityTypeBuilder<Category> builder)
		{
			builder.ToTable("Categories").HasKey(x=> x.Id);

			builder.HasIndex(x => x.Name).IsUnique();

			builder.HasData(SeedData.LoadCategories());
		}
	}
}
