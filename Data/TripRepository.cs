using Space.NewFolder;
using Space.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Space.Contracts;

namespace Space.Data
{
    public class TripRepository : RepositoryBase<Trip>, ITripRepository
    {
        public TripRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {
        }
    }
}
