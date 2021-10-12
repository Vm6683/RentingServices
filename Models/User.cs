using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RentingServices.Models
{
    public class User
    {
        [Required()]
        [Range(1, 99999)]
        [Display(Name = "User ID")]
        public string UserId { get; set; }
        [Required()]
        [MinLength(2)]
        public string Name { get; set; }
        [Required()]
        public string Email { get; set; }
        [Required()]
        [MinLength(9)]
        [Range(1000000000,9999999999)]
        public int  Phone { get; set; }

    }
}
