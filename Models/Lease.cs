using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RentingServices.Models
{
    public class Lease
    {
        [Required()]
        [Range(1, 99999)]
        [Display(Name = "Lease ID")]
        public int LeaseId { get; set; }
        
        [Range(1, 99999)]
        [Required()]
        public double Rent { get; set; }
        
        [Required()]

        public decimal SecurityDeposit { get; set;}

        [Required()]
        public string LeaseDate { get; set; }

        [Required()]
        public int PropertyId { get; set; }

        [Required()]
        public string UserId { get; set; }

        [Required()]
        public User User { get; set; }

        [Required()]
        public Property Property { get; set; }


    }
}
