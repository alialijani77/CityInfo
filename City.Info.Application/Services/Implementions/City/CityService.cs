using AutoMapper;
using City.Info.Application.Services.Interfaces;
using CityInfo.Domain.Interfaces.City;
using CityInfo.Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace City.Info.Application.Services.Implementions.City
{
	public class CityService : ICityService
	{
		private readonly ICityRepository _cityRepository;
		private readonly IMapper _mapper;

		public CityService(ICityRepository cityRepository, IMapper mapper)
        {
            _cityRepository = cityRepository;
			_mapper = mapper;
        }
        public async Task<IEnumerable<CityViewModel>> GetCitiesAsync()
		{
			var cities = await _cityRepository.GetCitiesAsync();
			var result = _mapper.Map<IEnumerable<CityInfo.Domain.Entities.City>, IEnumerable<CityViewModel>>(cities);
			return result;
		}

		public async Task<CityViewModel> GetCityAsync(int cityId, bool interestPointsOfInterest)
		{
			var city = await _cityRepository.GetCityAsync(cityId, interestPointsOfInterest);
			var result = _mapper.Map<CityViewModel>(city);
			return result;
		}
	}
}
