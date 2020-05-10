using Microsoft.AspNetCore.Mvc;
using PlanteraMera.Data;
using PlanteraMera.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanteraMera.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISeedRepository _repository;

        public HomeController(ISeedRepository repository)
        {
            _repository = repository;
        }

        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                BeginnerSeeds = _repository.BeginnerSeeds
            };

            return View(homeViewModel);
        }
    }
}
