using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityInfo.Domain.Entities
{
	public class UserCityInfo
	{
        [Key]
        public int Id { get; set; }

        public int UserId { get; set; }

        public int CityId { get; set; }

        public City City { get; set; }

        public User User { get; set; }
    }
}
