using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookApp.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BookApp.Controllers
{
    public class BookController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            var model = Repository.Aplications;
            return View(model);
        }

        public IActionResult Apply() //get için çalışır
        {
            return View();
        }



        [HttpPost] //gette yapılabilir

        [AutoValidateAntiforgeryToken]//doğrulama

        public IActionResult Apply( [FromForm] Book model)
        {
            Repository.Add(model);

            return View("Feedback", model);
        }



    }
}

