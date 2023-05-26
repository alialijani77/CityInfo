using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CityInfo.Domain.Entities
{
	public class User
	{
		[Key]
		public int Id { get; set; }
		[Display(Name = "نام")]
		[MaxLength(100, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد")]
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

		[Display(Name = "کلمه عبور")]
		[Required(ErrorMessage = "لطفا {0} را وارد کنید")]
		[MaxLength(100, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد")]
		public string Password { get; set; }


        #region Relation
        public ICollection<UserCityInfo> userCityInfos { get; set; }
        #endregion
    }
}
