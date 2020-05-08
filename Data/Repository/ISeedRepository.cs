using PlanteraMera.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanteraMera.Data
{
    public interface ISeedRepository
    {
        //IEnumerable<Seed> AllSeeds { get; }

        IEnumerable<Seed> GetAll();

        Seed GetSeedById(Guid seedId);
    }
}
