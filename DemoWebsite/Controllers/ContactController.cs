using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoWebsite.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DemoWebsite.Controllers
{
    public class ContactController : Controller
    {
        private readonly ILogger<ContactController> _logger;
        public readonly CMSDbContext _dbContext;

        public ContactController(ILogger<ContactController> logger, CMSDbContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            var page = _dbContext.CMSs.FirstOrDefault(x => x.Slug == "Contact");
            return View(page);
        }
    }
}