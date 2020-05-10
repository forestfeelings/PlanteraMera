using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PlanteraMera.Data;
using PlanteraMera.Data.Entities;
using PlanteraMera.Services;
using PlanteraMera.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanteraMera.Controllers
{
    public class AppController : Controller
    {
        private readonly IMailService _mailService;
        private readonly ISeedRepository _repository;
        private readonly UserManager<StoreUser> _userManager;

        public AppController(IMailService mailService, ISeedRepository repository, UserManager<StoreUser> userManager)
        {
            _mailService = mailService;
            _repository = repository;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("kontakt")]
        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost("kontakt")]
        public IActionResult Contact(ContactViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Send email
                _mailService.SendMessage("erica.i.gustafsson@gmail.com", model.Subject, $"From: {model.Name} - {model.Email}, Message: {model.Message}");
                ViewBag.UserMessage = "Meddelandet skickades!";
                ModelState.Clear();
            }

            return View();
        }

        public IActionResult About()
        {
            ViewBag.Title = "Om oss";

            return View();
        }

        public IActionResult Shop()
        {
            var results = _repository.GetAll();

            return View(results);
        }
    }
}
