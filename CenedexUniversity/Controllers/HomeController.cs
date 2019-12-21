using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CenedexUniversity.Models;
using CenedexUniversity.Model;

namespace CenedexUniversity.Controllers
{
    public class HomeController : Controller
    {
        private readonly cenedexUniversityDbContext _context;

        public HomeController(cenedexUniversityDbContext context)
        {
            _context = context;
           
        }
        public IActionResult Index()
        {
            var student = _context.Student.FirstOrDefault(s => s.Id == 4);
            return View(student);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Dashboard()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
