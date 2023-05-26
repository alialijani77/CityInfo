using CityInfo.Domain.Entities;
using CityInfo.Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityInfo.Domain.Interfaces.Authentication
{
	public interface IAuthenticationRepository
	{
		Task<bool> IsUserExist(User user);
	}
}
