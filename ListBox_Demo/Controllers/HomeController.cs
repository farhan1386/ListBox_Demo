using ListBox_Demo.Data;
using ListBox_Demo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;

namespace ListBox_Demo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext dbContext;

        public HomeController(ApplicationDbContext context)
        {
            dbContext = context;
        }

        public IActionResult Index()
        {
            ViewData["Id"] = new SelectList(dbContext.Skills, "Id", "ProgrammingLanguage");
            return View();
        }

        public IActionResult Skills()
        {
            var model = new Language();
            model.ProgrammingSkill.ToList();
            return View(model);
        }


    }
}
