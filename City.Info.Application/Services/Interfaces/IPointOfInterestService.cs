using CityInfo.Domain.Entities;
using CityInfo.Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace City.Info.Application.Services.Interfaces
{
	public interface IPointOfInterestService
	{
		Task<IEnumerable<PointOfInterestViewModel>> GetPointsOfInterestForCity(int cityId);

		Task<PointOfInterestViewModel?> GetPointOfInterestForCity(int cityId, int pointOfInterestId);
	}
}
