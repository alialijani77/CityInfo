using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CityInfo.Domain.Entities
{
	public class PointOfInterest
	{
		[Key]
        public int Id { get; set; }

		[Display(Name = "Name")]
		[Required(ErrorMessage = "{0} is required")]
		public string Name { get; set; }

		[Display(Name = "Address")]
		public string? Address { get; set; }

		[Display(Name = "Description")]
		public string? Description { get; set; }

        #region Relation
        public int CityId { get; set; }

		[ForeignKey("CityId")]
        public City? City { get; set; }

        #endregion
    }
}
