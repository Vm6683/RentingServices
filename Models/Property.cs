using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RentingServices.Models
{
    public class Property
    {
        [Range(1, 9999)]
        [Required()]
        [Display(Name ="Property ID")]
        public int PropertyID { get; set; }

        [Required()]
        [MinLength(2)]
        public string Type { get; set;}
        [Required()]
        [MinLength(2)]
        public string City { get; set; }
        [Required()]
        [MinLength(2)]
        public string Descripation { get; set; }
        [Required()]
        [MinLength(2)]
        public string Address { get; set; }

    }
}
