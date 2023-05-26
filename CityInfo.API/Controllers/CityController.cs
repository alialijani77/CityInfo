using City.Info.Application.Services.Interfaces;
using CityInfo.Domain.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CityInfo.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	[Authorize]
	public class CityController : ControllerBase
	{
		private readonly ICityService _cityService;
		private readonly IPointOfInterestService _pointOfInterestService;

		#region ctor
		public CityController(ICityService cityService, IPointOfInterestService pointOfInterestService)
		{
			_cityService = cityService;
			_pointOfInterestService = pointOfInterestService;
		}
		#endregion
		[HttpGet]
		public async Task<IActionResult> GetCities()
		{
			var result = await _cityService.GetCitiesAsync();
			return Ok(result);
		}

		[HttpGet("{id}")]
		public async Task<IActionResult> GetCityById(int id, bool interestPointsOfInterest)
		{
			var result = await _cityService.GetCityAsync(id, interestPointsOfInterest);
			return Ok(result);
		}

		[HttpPost]
		public async Task<IActionResult> CreatePointOfInterestForCity(CreatePointOfInterestForCityViewModel createPointOfInterestForCityViewModel)
		{
			if (await _pointOfInterestService.CreatePointOfInterestForCity(createPointOfInterestForCityViewModel))
			{
				return Ok();
			}
			return BadRequest();
		}

		[HttpPut]
		public async Task<IActionResult> UpdatePointOfInterestForCity(UpdatePointOfInterestForCityViewModel updatePointOfInterestForCityViewModel)
		{
			if (await _pointOfInterestService.UpdatePointOfInterestForCity(updatePointOfInterestForCityViewModel))
			{
				return Ok();
			}
			return BadRequest();
		}
	}
}
