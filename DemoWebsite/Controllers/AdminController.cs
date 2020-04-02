using System.Linq;
using System.Threading.Tasks;
using DemoWebsite.Data;
using DemoWebsite.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DemoWebsite.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        public readonly CMSDbContext _dbContext;
        public AdminController(CMSDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> ManageCMS()
        {
            return View(await _dbContext.CMSs.ToListAsync());
        }

        public IActionResult AddOrEdit(int id = 0, string slug = null)
        {
            if (id == 0)
            {
                if (slug != null)
                {
                    var d = _dbContext.CMSs.FirstOrDefault(x => x.Slug == slug);
                    return View(d);
                }
                else
                {
                    return View(new CMS());
                }
            }
            else
            {
                return View(_dbContext.CMSs.Find(id));
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Save([Bind("Id,Title,Content,Slug")] CMS cms)
        {
            //var cms = _dbContext.CMSs.FirstOrDefault(x => x.Title == data.Title);
            if (ModelState.IsValid)
            {
                if (cms.Id == 0)
                    //return View("Error");

                    _dbContext.Add(cms);
                else
                    _dbContext.Update(cms);
                await _dbContext.SaveChangesAsync();
            }
            return RedirectToAction(nameof(ManageCMS));
        }

        public async Task<IActionResult> Delete(int? id)
        {
            var cms = await _dbContext.CMSs
                .FindAsync(id);
            _dbContext.CMSs.Remove(cms);
            await _dbContext.SaveChangesAsync();
            return RedirectToAction(nameof(ManageCMS));
        }

    }
}