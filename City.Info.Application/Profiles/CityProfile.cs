using AutoMapper;
using CityInfo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace City.Info.Application.Profiles
{
	public class CityProfile : Profile
	{
		public CityProfile()
		{
			CreateMap<CityInfo.Domain.Entities.City, CityInfo.Domain.ViewModels.CityWithoutPointOfInterestViewModel>().ReverseMap()
				   .ForMember(d => d.Name, o => o.MapFrom(e => e.Name))
				   .ForMember(d => d.Id, o => o.MapFrom(e => e.Id))
				   .ForMember(d => d.Description, o => o.MapFrom(e => e.Description));

			CreateMap<CityInfo.Domain.Entities.City, CityInfo.Domain.ViewModels.CityViewModel>().ReverseMap()
				   .ForMember(d => d.Name, o => o.MapFrom(e => e.Name))
				   .ForMember(d => d.Id, o => o.MapFrom(e => e.Id))
				   .ForMember(d => d.Description, o => o.MapFrom(e => e.Description))
				  .ForMember(d => d.PointOfInterests, o => o.MapFrom(e => e.PointOfInterests));


			CreateMap<CityInfo.Domain.Entities.PointOfInterest, CityInfo.Domain.ViewModels.PointOfInterestViewModel>();

			CreateMap<CityInfo.Domain.ViewModels.CreatePointOfInterestForCityViewModel, CityInfo.Domain.Entities.PointOfInterest>();
			CreateMap<CityInfo.Domain.ViewModels.UpdatePointOfInterestForCityViewModel, CityInfo.Domain.Entities.PointOfInterest>();



		}
	}
}
