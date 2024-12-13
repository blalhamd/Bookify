namespace Bookify.DataAccess.Data.EntitiesConfig
{
	public class AreaConfig : IEntityTypeConfiguration<Area>
    {
        public void Configure(EntityTypeBuilder<Area> builder)
        {
            builder.ToTable("Areas").HasKey(x => x.Id);

            builder.HasData(SeedData.LoadAreas());
        }
    }
}
