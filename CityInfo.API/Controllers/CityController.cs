using City.Info.Application.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CityInfo.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CityController : ControllerBase
	{
		private readonly ICityService _cityService;

        #region ctor
        public CityController(ICityService cityService)
        {
			_cityService = cityService;
        }
        #endregion
        [HttpGet]
		public async Task<IActionResult> GetCities()
		{
			var result = await _cityService.GetCitiesAsync();
			return Ok(result);
		}
	}
}
