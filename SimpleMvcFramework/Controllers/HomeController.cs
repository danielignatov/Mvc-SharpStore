namespace SimpleMvcFramework.Controllers
{
    using BindingModels;
    using Data;
    using Models;
    using MVC.Interfaces.Generic;
    using SimpleHttpServer.Models;
    using SimpleMvcFramework.MVC.Attributes.Methods;
    using SimpleMvcFramework.MVC.Controllers;
    using SimpleMvcFramework.MVC.Interfaces;
    using System.Collections.Generic;
    using System.Linq;
    using ViewModels;

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
        public IActionResult<ShowProductsViewModel> Products()
        {

            List<Knife> knifes = new List<Knife>();

            using (var context = new SharpStoreContext())
            {
                knifes = context.Knifes.ToList();
            }

            var viewModel = new ShowProductsViewModel()
            {
                Knifes = knifes
            };

            return View(viewModel);
        }

        [HttpGet]
        public IActionResult Contacts()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Contacts(ReceiveMessageBindingModel model)
        {
            var message = new Message()
            {
                Email = model.Email,
                Title = model.Title,
                Content = model.Content
            };

            using (var context = new SharpStoreContext())
            {
                context.Messages.Add(message);
                context.SaveChanges();
            }

            return View();
        }
    }
}