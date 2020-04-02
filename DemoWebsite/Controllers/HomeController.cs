using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DemoWebsite.Models;
using DemoWebsite.Data;

namespace DemoWebsite.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public readonly CMSDbContext _dbContext;

        public HomeController(ILogger<HomeController> logger, CMSDbContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            var page = _dbContext.CMSs.FirstOrDefault(x => x.Slug == "Home");
            return View(page);
        }

        public IActionResult Privacy()
        {
            var page = _dbContext.CMSs.FirstOrDefault(x => x.Slug == "PrivacyPolicy");
            return View(page);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
