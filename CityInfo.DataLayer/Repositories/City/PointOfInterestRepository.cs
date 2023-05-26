using CityInfo.DataLayer.Context;
using CityInfo.Domain.Entities;
using CityInfo.Domain.Interfaces.City;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityInfo.DataLayer.Repositories.City
{
	public class PointOfInterestRepository : IPointOfInterestRepository
	{
		private readonly CityInfoDbContext _context;

		public PointOfInterestRepository(CityInfoDbContext context)
		{
			_context = context;
		}		

		public async Task<PointOfInterest?> GetPointOfInterestForCity(int cityId, int pointOfInterestId)
		{
			return await _context.PointOfInterests.Where(p => p.CityId == cityId && p.Id == pointOfInterestId).FirstOrDefaultAsync();

		}

		public async Task<IEnumerable<PointOfInterest>> GetPointsOfInterestForCity(int cityId)
		{
			return await _context.PointOfInterests.Where(p => p.CityId == cityId).ToListAsync();
		}

		public async Task CreatePointOfInterestForCity(PointOfInterest pointOfInterest)
		{
			await _context.PointOfInterests.AddAsync(pointOfInterest);
		}

		public async Task SaveChange()
		{
			await _context.SaveChangesAsync();
		}

		public async Task UpdatePointOfInterestForCity(PointOfInterest pointOfInterest)
		{
			 _context.PointOfInterests.Update(pointOfInterest);
		}
	}
}
