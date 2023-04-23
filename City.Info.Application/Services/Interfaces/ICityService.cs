using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace City.Info.Application.Services.Interfaces
{
	public interface ICityService
	{
		Task<IEnumerable<CityInfo.Domain.ViewModels.CityViewModel>> GetCitiesAsync();

		Task<CityInfo.Domain.ViewModels.CityViewModel> GetCityAsync(int cityId, bool interestPointsOfInterest);
	}
}
