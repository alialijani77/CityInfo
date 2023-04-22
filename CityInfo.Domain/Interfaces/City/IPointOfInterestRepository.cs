using CityInfo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityInfo.Domain.Interfaces.City
{
	public interface IPointOfInterestRepository
	{
		Task<IEnumerable<PointOfInterest>> GetPointsOfInterestForCity(int cityId);

		Task<PointOfInterest?> GetPointOfInterestForCity(int cityId,int pointOfInterestId);
	}
}
