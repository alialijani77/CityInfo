using CityInfo.DataLayer.Context;
using CityInfo.Domain.Entities;
using CityInfo.Domain.Interfaces.Authentication;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityInfo.DataLayer.Repositories.Authentication
{
	public class AuthenticationRepository : IAuthenticationRepository
	{
		private readonly CityInfoDbContext _context;

        public AuthenticationRepository(CityInfoDbContext context)
        {
            _context = context;
        }
        public async Task<bool> IsUserExist(User user)
		{
			return await _context.Users.AnyAsync(u => u.Email == user.Email && u.Password == user.Password);
		}
	}
}
