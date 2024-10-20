using Bookify.Business.Services;
using Bookify.Core.AutoMapper;
using Bookify.Core.IRepositories.Generic;
using Bookify.Core.IServices;
using Bookify.Core.IUnit;
using Bookify.DataAccess.Data.Context;
using Bookify.DataAccess.Repositories.Generic;
using Bookify.DataAccess.Unit;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

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
