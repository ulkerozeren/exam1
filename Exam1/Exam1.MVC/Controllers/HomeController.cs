using Microsoft.AspNetCore.Mvc;

namespace Exam1.MVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
