using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityInfo.Domain.Entities
{
	public class City
	{
		[Key]
        public int Id { get; set; }

		[Display(Name = "Name")]
		[Required(ErrorMessage = "{0} is required")]
		public string Name { get; set; }

		[Display(Name = "Description")]
		public string? Description { get; set; }

        #region Relation

        public ICollection<PointOfInterest> PointOfInterests { get; set; }

		public ICollection<UserCityInfo> userCityInfos { get; set; }


		#endregion
	}
}
