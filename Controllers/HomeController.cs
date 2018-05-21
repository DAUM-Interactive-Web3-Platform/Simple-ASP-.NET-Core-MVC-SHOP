using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyShop.Models;
using MyShop.ViewModels;

namespace MyShop.Controllers
{
    public class HomeController : Controller
    {
        private ISnowboardRepository _snowboardRepository;

        public HomeController(ISnowboardRepository snowboardRepository)
        {
            _snowboardRepository = snowboardRepository;
        }

        public IActionResult Index()
        {
            var snowboards = _snowboardRepository.GetAllSnowboards().OrderBy(s => s.Brand);
            


            var homeViewModel = new HomeViewModel()
            {
                Snowboards = snowboards.ToList(),
                Title = "SnowShop"
            };

            return View(homeViewModel);
        }

   

        public IActionResult Details(int id)
        {
            var snowboard = _snowboardRepository.GetSnowboardById(id);
            if(snowboard == null)
            {
                return NotFound();
            }

            return View(snowboard);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
