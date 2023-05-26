using AutoMapper;
using City.Info.Application.Services.Interfaces;
using CityInfo.Domain.Entities;
using CityInfo.Domain.Interfaces.City;
using CityInfo.Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace City.Info.Application.Services.Implementions.City
{
	public class PointOfInterestService : IPointOfInterestService
	{
		private readonly ICityRepository _cityRepository;
		private readonly IPointOfInterestRepository _pointOfInterestRepository;
		private readonly IMapper _mapper;
		public PointOfInterestService(ICityRepository cityRepository, IPointOfInterestRepository pointOfInterestRepository, IMapper mapper)
		{
			_cityRepository = cityRepository;
			_pointOfInterestRepository = pointOfInterestRepository;
			_mapper = mapper;
		}

		public async Task<bool> CreatePointOfInterestForCity(CreatePointOfInterestForCityViewModel createPointOfInterestForCityViewModel)
		{
			if (!await _cityRepository.CityExistsAsync(createPointOfInterestForCityViewModel.CityId))
			{
				return false;
			}
			var result = _mapper.Map<CityInfo.Domain.Entities.PointOfInterest>(createPointOfInterestForCityViewModel);
			await _pointOfInterestRepository.CreatePointOfInterestForCity(result);
			await _pointOfInterestRepository.SaveChange();
			return true;
		}

		public async Task<PointOfInterest?> GetPointOfInterestForCity(int cityId, int pointOfInterestId)
		{
			return await _pointOfInterestRepository.GetPointOfInterestForCity(cityId, pointOfInterestId);
		}

		public Task<IEnumerable<PointOfInterestViewModel>> GetPointsOfInterestForCity(int cityId)
		{
			throw new NotImplementedException();
		}

		public async Task<bool> UpdatePointOfInterestForCity(UpdatePointOfInterestForCityViewModel updatePointOfInterestForCityViewModel)
		{
			if (!await _cityRepository.CityExistsAsync(updatePointOfInterestForCityViewModel.CityId))
			{
				return false;
			}
			var pointOfInterest = await GetPointOfInterestForCity(updatePointOfInterestForCityViewModel.CityId, updatePointOfInterestForCityViewModel.Id);

			if(pointOfInterest == null)
			{
				return false;
			}
			//pointOfInterest.Address = updatePointOfInterestForCityViewModel.Address;
			//pointOfInterest.Name = updatePointOfInterestForCityViewModel.Name;
			//pointOfInterest.Description = updatePointOfInterestForCityViewModel.Description;
			//pointOfInterest.CityId = updatePointOfInterestForCityViewModel.CityId;
			//await _pointOfInterestRepository.UpdatePointOfInterestForCity(pointOfInterest);
			_mapper.Map(updatePointOfInterestForCityViewModel,pointOfInterest);
			await _pointOfInterestRepository.SaveChange();
			return true;
		}
	}
}
