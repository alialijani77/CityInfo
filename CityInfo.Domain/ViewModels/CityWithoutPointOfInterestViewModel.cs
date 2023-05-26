using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CityInfo.Domain.ViewModels
{
	public class CityWithoutPointOfInterestViewModel
	{
		public int Id { get; set; }

		[Display(Name = "Name")]
		[Required(ErrorMessage = "{0} is required")]
		public string Name { get; set; }

		[Display(Name = "Description")]
		public string? Description { get; set; }
	}
}
