using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Space.Models;

namespace Space.Data
{
    public class SpaceContext : DbContext
    {
        public SpaceContext (DbContextOptions<SpaceContext> options)
            : base(options)
        {
        }

        public DbSet<Space.Models.Itinerary> Itinerary { get; set; }
    }
}
