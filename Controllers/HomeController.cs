using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCWebApplication.Models;

namespace MVCWebApplication.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Product()
        {
            // instantiate repository
            var context = new ProductContext();

            // get data from repository
            var products = context.GetByCategory("Toy");

            return View(products);
        }

        public IActionResult Single()
        {
            // instantiate repository
            var context = new ProductContext();

            // get data from repository
            var product = context.GetById(2);

            return View(product);
        }
    }
}