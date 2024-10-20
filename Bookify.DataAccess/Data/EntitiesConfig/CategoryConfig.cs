using Bookify.DataAccess.Seed;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bookify.DataAccess.Data.EntitiesConfig
{
	public class CategoryConfig : IEntityTypeConfiguration<Category>
	{
		public void Configure(EntityTypeBuilder<Category> builder)
		{
			builder.ToTable("Categories").HasKey(x=> x.Id);

			builder.HasData(SeedData.LoadCategories());
		}
	}
}
