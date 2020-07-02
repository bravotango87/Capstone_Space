using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Space.Models
{
    public class Trip
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Destination { get; set; }

        [Display(Name ="Departure")]
        public string LaunchLocation { get; set; }

        [Display(Name ="Cost")]
        public int TripCost { get; set; }

        public string Duration { get; set; }

        [Display(Name ="Guests")]
        public int AmountOfGuests { get; set; }

        public string Date { get; set; }

        [ForeignKey("IdentityUser")]
        public string IdentityUserId { get; set; }
        public IdentityUser IdentityUser { get; set; }
    }
}
