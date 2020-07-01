using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

        public string LaunchLocation { get; set; }

        public int TripCost { get; set; }

        public string Duration { get; set; }

        public int AmountOfGuests { get; set; }
    }
}
