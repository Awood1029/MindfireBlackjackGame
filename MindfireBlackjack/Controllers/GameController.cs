using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MindfireBlackjack.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MindfireBlackjack.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            Session session = new Session();
            
            return View(session);
        }

        public IActionResult Hit()
        {
            return View();
        }

    }
}
