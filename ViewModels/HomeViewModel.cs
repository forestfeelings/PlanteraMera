using PlanteraMera.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanteraMera.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Seed> BeginnerSeeds { get; set; }
    }
}
