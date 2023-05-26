using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CityInfo.Domain.ViewModels
{
	public class UserViewModel
	{
		public string? FirstName { get; set; }

		[Display(Name = "نام خانوادگی")]
		[MaxLength(100, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد")]
		public string? LastName { get; set; }

		[Display(Name = "شماره تماس")]
		[MaxLength(20, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد")]
		public string? PhoneNumber { get; set; }

		[Display(Name = "ایمیل")]
		[MaxLength(100, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد")]
		[EmailAddress(ErrorMessage = "ایمیل وارد شده معتبر نمی باشد .")]
		[Required(ErrorMessage = "لطفا {0} را وارد کنید")]
		public string Email { get; set; }
	}
}
