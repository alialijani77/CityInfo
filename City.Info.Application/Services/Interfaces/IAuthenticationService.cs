using CityInfo.Domain.Entities;
using CityInfo.Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace City.Info.Application.Services.Interfaces
{
	public interface IAuthenticationService
	{
		Task<string> Authenticate(UserLoginViewModel userLoginViewModel);
	}
}
