using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanteraMera.Data.Entities
{
    public class PlanteraContext : DbContext
    {
        public DbSet<Seed> Seeds { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
