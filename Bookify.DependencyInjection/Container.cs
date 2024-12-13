namespace Bookify.DependencyInjection
{
	public static class Container
	{
		public static IServiceCollection RegisterConfig(this IServiceCollection services,IConfiguration configuration)
		{
			// Register ConnectionString

			services.RegisterConnectionString(configuration);

			// Register Identity Config

			services.RegisterIdentityConfig();

			// Register Services 

			services.RegisterServices();

			services.RegisterRepositories();

			// Register Email Config

			services.RegisterEmailConfig(configuration);

			// Register Data Protection Config

			services.RegisterDataProtectionConfig();

			services.AddAutoMapper(typeof(MappingProfile));

			services.AddHttpContextAccessor();

			return services;
		}

		private static IServiceCollection RegisterConnectionString(this IServiceCollection services, IConfiguration configuration)
		{
			var connection = configuration["ConnectionStrings:DefaultConnectionString"];
			services.AddDbContext<AppDbContext>(options=> options.UseSqlServer(connection));
			services.AddScoped<AppDbContext, AppDbContext>();

			return services;
		}

		private static IServiceCollection RegisterServices(this IServiceCollection services)
		{
			services.AddScoped<ICategoryService, CategoryService>();
			services.AddScoped<IBookService, BookService>();
			services.AddScoped<IAuthorService, AuthorService>();
			services.AddScoped<IBookCopyService, BookCopyService>();
			services.AddScoped<IEmailSender, EmailSender>();
			services.AddScoped<IEmailBodyBuilder, EmailBodyBuilder>();
			services.AddScoped<IAreaService, AreaService>();
			services.AddScoped<IGovernorateService, GovernorateService>();
			services.AddScoped<ISubscriberService, SubscriberService>();
			services.AddScoped<IImageService, ImageService>();
			services.AddSingleton<ILoggerService, LoggerService>();

			return services;
		}

		private static IServiceCollection RegisterRepositories(this IServiceCollection services)
		{
			services.AddScoped(typeof(IGenericRepositoryAsync<>),typeof(GenericRepositoryAsync<>));
			services.AddScoped<IUnitOfWorkAsync, UnitOfWorkAsync>();

			return services;
		}

		private static IServiceCollection RegisterIdentityConfig(this IServiceCollection services)
		{
			services.AddIdentity<AppUser,AppRole>(options=>
			{
				options.SignIn.RequireConfirmedEmail = true;
				options.Password.RequiredLength = 8;
				options.User.RequireUniqueEmail = true;
				options.Lockout.AllowedForNewUsers = true;
				options.Lockout.MaxFailedAccessAttempts = 5;
				options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(20);
			})
				.AddEntityFrameworkStores<AppDbContext>()
				.AddDefaultTokenProviders()
				.AddDefaultUI();
			
			return services;
		}

		private static IServiceCollection RegisterEmailConfig(this IServiceCollection services,IConfiguration configuration)
		{
			services.Configure<MailSettings>(configuration.GetSection(nameof(MailSettings)));

			return services;
		}

		private static IServiceCollection RegisterDataProtectionConfig(this IServiceCollection services)
		{
			services.AddDataProtection().SetApplicationName(nameof(Bookify));

			return services;
		}
	}
}
