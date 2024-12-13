namespace Bookify.DataAccess.Data.EntitiesConfig
{
    public class GovernorateConfig : IEntityTypeConfiguration<Governorate>
    {
        public void Configure(EntityTypeBuilder<Governorate> builder)
        {
            builder.ToTable("Governorates").HasKey(x => x.Id);

            builder.HasData(SeedData.LoadGovernorates());
        }
    }
}
