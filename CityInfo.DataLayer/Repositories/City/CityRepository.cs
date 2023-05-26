using CityInfo.DataLayer.Context;
using CityInfo.Domain.Interfaces.City;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityInfo.DataLayer.Repositories.City
{
	public class CityRepository : ICityRepository
	{
		private readonly CityInfoDbContext _context;

        public CityRepository(CityInfoDbContext context)
        {
            _context = context;
        }

		public async Task<bool> CityExistsAsync(int cityId)
		{
			return await _context.Cities.AnyAsync(c => c.Id == cityId);
		}

		public async Task<IEnumerable<Domain.Entities.City>> GetCitiesAsync()
		{
			return await _context.Cities.OrderBy(c => c.Name).ToListAsync();
		}

		public async Task<Domain.Entities.City?> GetCityAsync(int cityId, bool interestPointsOfInterest)
		{
			if(interestPointsOfInterest)
			{
				return await _context.Cities.Include(c => c.PointOfInterests).Where(c => c.Id == cityId).FirstOrDefaultAsync();
			}
			return await _context.Cities.Where(c => c.Id == cityId).FirstOrDefaultAsync();

		}
	}
}
