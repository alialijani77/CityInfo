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
	public class PointOfInterestService : IPointOfInterestService
	{
		private readonly IPointOfInterestRepository _pointOfInterestRepository;
		private readonly IMapper _mapper;
		public PointOfInterestService(IPointOfInterestRepository pointOfInterestRepository, IMapper mapper)
		{
			_pointOfInterestRepository = pointOfInterestRepository;
			_mapper = mapper;
		}
		public Task<PointOfInterestViewModel?> GetPointOfInterestForCity(int cityId, int pointOfInterestId)
		{
			throw new NotImplementedException();
		}

		public Task<IEnumerable<PointOfInterestViewModel>> GetPointsOfInterestForCity(int cityId)
		{
			throw new NotImplementedException();
		}
	}
}
