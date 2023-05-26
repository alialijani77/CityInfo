using City.Info.Application.Services.Interfaces;
using CityInfo.Domain.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CityInfo.API.Controllers
{
	[Route("api/authentication")]
	[ApiController]
	public class AuthenticationController : ControllerBase
	{
		private readonly IAuthenticationService _authenticationService;

        public AuthenticationController(IAuthenticationService authenticationService)
        {
            _authenticationService = authenticationService;
        }
        [HttpPost("authenticate")]
		public async Task<IActionResult> Authenticate(UserLoginViewModel userLoginViewModel)
		{
			var tokenToReturn = await _authenticationService.Authenticate(userLoginViewModel);

			return Ok(tokenToReturn);
		}
	}
}
