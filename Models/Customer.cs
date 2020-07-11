using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TrashManagement.Models
{
    public class Customer
    {
        [Key]

        public int Id { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]

        public string LastName { get; set; }

        [Display(Name = "Address")]

        public string StreetAddress { get; set; }
       

        [Display(Name = "Zip Code")]
        public int ZipCode { get; set; }

        public double Balance { get; set; }




        [Display(Name = "Trash Pickup Day")]
        public string PickupDay { get; set; }

        [Display(Name = "Extra Pick Day")]

        public string ExtraPickup { get; set; }





        [Display(Name = "Request To Start Suspension Of Pickup")]
        public string StartSuspend { get; set; }

        [Display(Name = "Request To End Suspension Of Pickup")]
        public string EndSuspend { get; set; }












        [ForeignKey("IdentityUser")]

        public string IdentityUserId { get; set; }
        public IdentityUser IdentityUser { get; set; }
    }

}
