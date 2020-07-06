using Microsoft.AspNetCore.Identity;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Space.Models
{
    public class Itinerary
    {
        [Key]

        public int ItineraryId { get; set; }

        public string RequiredForms { get; set; }

        public string Destination { get; set; }

        public string WhatToBring { get; set; }

        public DateFormat Depature { get; set; }

        public string ThreeWeeksPrior { get; set; }

        public string DayOfLaunch { get; set; }

        public string Arrival { get; set; }

        public string WhatToDo { get; set; }


        public string FlyingBack { get; set; }








       

        

        

       [ForeignKey("IdentityUser")]

        public string IdentityUserId { get; set; }

        public IdentityUser IdentityUser { get; set; }


    }
}
