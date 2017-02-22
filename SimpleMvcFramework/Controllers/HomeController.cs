namespace SimpleMvcFramework.Controllers
{
    using SimpleMvcFramework.MVC.Attributes.Methods;
    using SimpleMvcFramework.MVC.Controllers;
    using SimpleMvcFramework.MVC.Interfaces;

    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult About()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Products()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Contacts()
        {
            return View();
        }
    }
}