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


		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<City>().HasData(
				new City()
				{
					Id = 1,
					Name = "Tehran",
					Description = "No Description"

				},
				new City()
				{
					Id = 2,
					Name = "Alborz",
					Description = "No Description"

				});

			modelBuilder.Entity<PointOfInterest>().HasData(
				new PointOfInterest()
				{
					Id = 1,
					CityId = 1,
					Name = "Bam Resalat",
					Address = "Resalat",
					Description = "No Description"
				},
				new PointOfInterest()
				{
					Id = 2,
					CityId = 2,
					Name = "Bam Karaj",
					Address = "Azimiye",
					Description = "No Description"
				}
				);
			base.OnModelCreating(modelBuilder);
		}

	}
}
