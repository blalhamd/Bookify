namespace Bookify.DependencyInjection
{
	public static class Container
	{
		public static IServiceCollection RegisterConfig(this IServiceCollection services,IConfiguration configuration)
		{
			// Register ConnectionString

			services.RegisterConnectionString(configuration);

			// Register Services 

			services.RegisterServices();

			services.RegisterRepositories();

			services.AddAutoMapper(typeof(MappingProfile));

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
			services.AddScoped<IBookService, AuthorService>();

			return services;
		}

		private static IServiceCollection RegisterRepositories(this IServiceCollection services)
		{
			services.AddScoped(typeof(IGenericRepositoryAsync<>),typeof(GenericRepositoryAsync<>));
			services.AddScoped<IUnitOfWorkAsync, UnitOfWorkAsync>();

			return services;
		}
	}
}
