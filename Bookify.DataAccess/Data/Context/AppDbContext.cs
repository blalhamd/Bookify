namespace Bookify.DataAccess.Data.Context
{
	public class AppDbContext : IdentityDbContext<AppUser,AppRole,int>
	{
		public DbSet<Author> Authors { get; set; }
		public DbSet<Area> Areas { get; set; }
		public DbSet<Book> Books { get; set; }
		public DbSet<BookCopy> BookCopies { get; set; }
		public DbSet<Category> Categories { get; set; }
		public DbSet<BookCategory> BookCategories { get; set; }
		public DbSet<Governorate> Governorates { get; set; }
		public DbSet<Subscriber> subscribers { get; set; }
		public DbSet<Subscription> Subscriptions { get; set; }
		public DbSet<Rental> Rentals { get; set; } 
		public DbSet<RentalCopy> RentalCopies { get; set; } 

		private readonly IHttpContextAccessor _contextAccessor;
        public AppDbContext(DbContextOptions<AppDbContext> options,IHttpContextAccessor contextAccessor) : base(options)
        {
            _contextAccessor = contextAccessor;
        }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

            #region to make all deletion behavior as restrict and apply it in starting the project

            var cascadeFks = modelBuilder.Model.GetEntityTypes()
				                             .SelectMany(t=> t.GetForeignKeys())
											 .Where(fk=> fk.DeleteBehavior == DeleteBehavior.Cascade && !fk.IsOwnership)
											 .ToList();

			foreach (var fk in cascadeFks)
			{
				fk.DeleteBehavior = DeleteBehavior.Restrict;
			}

            #endregion

            modelBuilder.HasSequence<int>("SerialNumber", "Shared")
									.StartsAt(1000_0001)
									.IncrementsBy(2);

			modelBuilder.Entity<IdentityUserClaim<int>>().ToTable("UserClaims", schema: "UserManagement");
			modelBuilder.Entity<IdentityUserLogin<int>>().ToTable("UserLogin",schema: "UserManagement");
			modelBuilder.Entity<IdentityUserToken<int>>().ToTable("UserToken",schema: "UserManagement");

			modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
		}

		public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
		{
			var entries = ChangeTracker.Entries<BaseEntity>();

			var CurrentUserIdClaim = _contextAccessor.HttpContext?.User?.FindFirst(ClaimTypes.NameIdentifier);

			int? CurrentUserId = null;

			if (CurrentUserIdClaim != null && int.TryParse(CurrentUserIdClaim.Value, out var parsedUserId))
			{
				CurrentUserId = parsedUserId;
			}

			foreach (var entryEntity in entries)
			{
				if (entryEntity != null && CurrentUserId is not null)
				{

					if (entryEntity.State == EntityState.Added)
					{
						entryEntity.Property(x => x.CreationTime).CurrentValue = DateTime.UtcNow;
						entryEntity.Property(x => x.CreatedByUserId).CurrentValue = CurrentUserId.Value;
					}
					else if (entryEntity.State == EntityState.Modified)
					{

						if (entryEntity.Property(x => x.FirstModificationDate).CurrentValue is null && entryEntity.Property(x => x.FirstModificationByUserId).CurrentValue is null)
						{
							entryEntity.Property(x => x.FirstModificationByUserId).CurrentValue = CurrentUserId.Value;
							entryEntity.Property(x => x.FirstModificationDate).CurrentValue = DateTime.UtcNow;
						}
						else
						{
							entryEntity.Property(x => x.LastModificationByUserId).CurrentValue = CurrentUserId.Value;
							entryEntity.Property(x => x.LastModificationDate).CurrentValue = DateTime.UtcNow;
						}
					}
					else if (entryEntity.State == EntityState.Deleted && entryEntity.Entity is ISoftDeletable)
					{
						entryEntity.State = EntityState.Modified;

						entryEntity.Property(x => x.DeletionTime).CurrentValue = DateTime.Now;
						entryEntity.Property(x => x.IsDeleted).CurrentValue = true;
						entryEntity.Property(x => x.DeletedByUserId).CurrentValue = CurrentUserId.Value;
					}
				}
			}

			return base.SaveChangesAsync(cancellationToken);
		}
	}
}
