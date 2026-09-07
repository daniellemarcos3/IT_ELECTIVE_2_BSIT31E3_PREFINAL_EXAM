using System.Diagnostics;
using IT_ELECTIVE_2_BSIT31E3_PREFINAL_EXAM.Models;
using Microsoft.AspNetCore.Mvc;

namespace IT_ELECTIVE_2_BSIT31E3_PREFINAL_EXAM.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Questions()
        {
            return View("~/Views/Exam/Questions.cshtml");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel
            {
                RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier
            });
        }
    }
}
