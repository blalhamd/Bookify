namespace Bookify.DataAccess.Data.EntitiesConfig
{
    public class SubscriberConfig : IEntityTypeConfiguration<Subscriber>
    {
        public void Configure(EntityTypeBuilder<Subscriber> builder)
        {
            builder.ToTable("Subscribers").HasKey(x => x.Id);

            builder.HasData(SeedData.LoadSubscribers());
        }
    }
}
