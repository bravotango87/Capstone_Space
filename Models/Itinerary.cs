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

        [Display(Name ="Must Bring 1")]
        public string RequiredForms { get; set; }

        [Display(Name ="Where You Going ?")]
        public string Destination { get; set; }

        [Display(Name ="Items To Bring")]
        public string WhatToBring { get; set; }


        public string Depature { get; set; }

        [Display(Name="3 Weeks Before")]
        public string ThreeWeeksPrior { get; set; }

        [Display(Name ="Launch Day")]
        public string DayOfLaunch { get; set; }

        [Display(Name ="When You Land")]
        public string Arrival { get; set; }

        [Display(Name="While You're There")]
        public string WhatToDo { get; set; }

        [Display(Name ="Heading Home")]
        public string FlyingBack { get; set; }








       

        

        

       [ForeignKey("IdentityUser")]

        public string IdentityUserId { get; set; }

        public IdentityUser IdentityUser { get; set; }


    }
}
