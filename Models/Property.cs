using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RentingServices.Models
{
    public class Property
    {
   
        [Display(Name ="Property ID")]
        public int PropertyID { get; set; }

        public string Type { get; set;}
        
        public string City { get; set; }
       
        public string Descripation { get; set; }
      
        public string Address { get; set; }

    }
}
