using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ToDoSolution.Models;
using ToDoSolution.Services;

namespace ToDoSolution.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEmailSenderService _service;

        public HomeController(IEmailSenderService service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
           
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
