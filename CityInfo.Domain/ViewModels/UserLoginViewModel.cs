﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CityInfo.Domain.ViewModels
{
	public class UserLoginViewModel
	{

		[Display(Name = "ایمیل")]
		[MaxLength(100, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد")]
		[EmailAddress(ErrorMessage = "ایمیل وارد شده معتبر نمی باشد .")]
		[Required(ErrorMessage = "لطفا {0} را وارد کنید")]
		public string Email { get; set; }

		[Display(Name = "کلمه عبور")]
		[Required(ErrorMessage = "لطفا {0} را وارد کنید")]
		[MaxLength(100, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد")]
		public string Password { get; set; }
	}
}
