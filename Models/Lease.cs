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

        [Display(Name = "Lease ID")]
        public int LeaseId { get; set; }
   
        public double Rent { get; set; }
        

        public decimal SecurityDeposit { get; set;}

        public DateTime LeaseDate { get; set; }

        public string Photo { get; set; }

        public int PropertyId { get; set; }


        public string TenantId { get; set; }

        public Tenant Tenant { get; set; }

     
        public Property Property { get; set; }


    }
}
