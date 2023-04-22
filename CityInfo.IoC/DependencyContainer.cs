using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CityInfo.DataLayer.Repositories.City;
using CityInfo.Domain.Interfaces.City;
using Microsoft.Extensions.DependencyInjection;


namespace CityInfo.IoC
{
	public static class DependencyContainer
	{
		public static void RegisterDependencies(IServiceCollection services)
		{
			#region Services

			#endregion

			#region Repositories
			services.AddScoped<ICityRepository, CityRepository>();
			services.AddScoped<IPointOfInterestRepository, PointOfInterestRepository>();

			#endregion
		}
	}
}
