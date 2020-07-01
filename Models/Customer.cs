using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Space.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Enter Phone Number Including No Area Code. No Dashes")]
        public int PhoneNumber { get; set; }

        [Display(Name = "Enter Your Age")]
        public int Age { get; set; }

        [Display(Name = "Gender. Please Enter Male, Female, or N/A")]

        public string Gender { get; set; }


        [ForeignKey("Trip")]

        [Display(Name = "Company Name")]


        public string IdentityUserId { get; set; }

        public IdentityUser IdentityUser { get; set; }
    }
}
