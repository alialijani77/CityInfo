using CityInfo.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityInfo.DataLayer.Context
{
	public class CityInfoDbContext : DbContext
	{
		#region ctor
		public CityInfoDbContext(DbContextOptions<CityInfoDbContext> options) : base(options)
		{

		}
        #endregion

        public DbSet<City> Cities { get; set; }

        public DbSet<PointOfInterest> PointOfInterests { get; set; }

    }
}
