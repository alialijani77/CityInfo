using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using City.Info.Application.Profiles;
using City.Info.Application.Services.Implementions.Authentication;
using City.Info.Application.Services.Implementions.City;
using City.Info.Application.Services.Interfaces;
using CityInfo.DataLayer.Repositories.Authentication;
using CityInfo.DataLayer.Repositories.City;
using CityInfo.Domain.Interfaces.Authentication;
using CityInfo.Domain.Interfaces.City;
using Microsoft.Extensions.DependencyInjection;


namespace CityInfo.IoC
{
	public static class DependencyContainer
	{
		public static void RegisterDependencies(IServiceCollection services)
		{
			#region Services
			services.AddScoped<IPointOfInterestService, PointOfInterestService>();
			services.AddScoped<ICityService, CityService>();
			services.AddScoped<IAuthenticationService, AuthenticationService>();

			#endregion

			#region Repositories
			services.AddScoped<ICityRepository, CityRepository>();
			services.AddScoped<IPointOfInterestRepository, PointOfInterestRepository>();
			services.AddScoped<IAuthenticationRepository, AuthenticationRepository>();

			#endregion

			#region AutoMapper
			services.AddAutoMapper(Assembly.GetExecutingAssembly());
			services.AddAutoMapper(typeof(CityProfile));

			#endregion
		}
	}
}
