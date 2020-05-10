using Microsoft.AspNetCore.Mvc;
using PlanteraMera.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanteraMera.Controllers
{
    public class SeedController : Controller
    {
        private readonly ISeedRepository _repository;

        public SeedController(ISeedRepository repository)
        {
            _repository = repository;
        }

        public IActionResult List()
        {
            var results = _repository.GetAll();

            return View(results);
        }

        //public IActionResult Details(Guid id)
        //{
        //    var seed = _repository.GetSeedById(id);
        //    if (seed == null)
        //        return NotFound();
        //    return View(seed);
        //}
    }
}
