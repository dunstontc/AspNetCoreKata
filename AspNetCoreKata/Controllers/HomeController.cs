using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AspNetCoreKata.Models;
using AspNetCoreKata.ProductRepository;

namespace AspNetCoreKata.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductRepo _repo;
        
        public HomeController(IProductRepo repo)
        {
            _repo = repo;
        }
        
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            var prod = _repo.GetProductWithId(2);
            
            ViewData["Message"] = $"Your product name is: {prod.Name}";

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
