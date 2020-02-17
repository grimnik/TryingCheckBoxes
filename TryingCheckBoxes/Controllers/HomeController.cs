using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TryingCheckBoxes.Models;

namespace TryingCheckBoxes.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(IndexViewModel incoming)
        {
           
            IndexViewModel model = new IndexViewModel();
            List<string> filters = new List<string>();
            model.Filters = new List<Filter>();
            for (int i = 0; i < 10; i++)
            {
                filters.Add("Option" + i);
                model.Filters.Add(new Filter());
            }
            for (int i = 0; i < filters.Count; i++)
            {
                model.Filters[i].Name = filters[i];
            }
          return  View(model);
        }

        public IActionResult Privacy()
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
