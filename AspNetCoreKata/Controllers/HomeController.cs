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
        
        public HomeController(IProductRepo repo) => _repo = repo;

        public IActionResult Index() => View();

        public IActionResult About() => View();

        public IActionResult Contact()
        {
            ViewData["Message"] = "Web Design & Application/Service Development";

            return View();
        }
        
        public IActionResult Products()
        {
            var prods = _repo.GetAllProducts();

            return View(prods);
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
