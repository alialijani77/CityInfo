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

		Task<PointOfInterest?> GetPointOfInterestForCity(int cityId, int pointOfInterestId);

		Task<bool> CreatePointOfInterestForCity(CreatePointOfInterestForCityViewModel createPointOfInterestForCityViewModel);

		Task<bool> UpdatePointOfInterestForCity(UpdatePointOfInterestForCityViewModel updatePointOfInterestForCityViewModel);

	}
}
