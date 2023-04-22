using CityInfo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityInfo.Domain.Interfaces.City
{
	public interface ICityRepository
	{
		Task<IEnumerable<CityInfo.Domain.Entities.City>> GetCitiesAsync();

		Task<CityInfo.Domain.Entities.City?> GetCityAsync(int cityId, bool interestPointsOfInterest);

	}
}
