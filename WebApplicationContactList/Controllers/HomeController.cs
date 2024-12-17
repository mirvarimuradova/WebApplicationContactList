using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplicationContactList.Models;
using WebApplicationContactList.Repository;

namespace WebApplicationContactList.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        ContactRepository contactRepository = new ContactRepository();
        public IActionResult Index()
        {


            return View(contactRepository.GetContact());
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
