using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PlanteraMera.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanteraMera.Data
{
    public class PlanteraContext : IdentityDbContext<StoreUser>
    {
        public PlanteraContext(DbContextOptions<PlanteraContext> options) : base(options)
        {
        }

        public DbSet<Seed> Seeds { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
