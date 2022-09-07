using Microsoft.AspNetCore.Mvc;
using NyDemo.Areas.Demo.ViewModels;


namespace NyDemo.Areas.Demo.Controllers
{
    public class HomeController : Controller
    {
        // HTTP GET https://localhost:xxxx/Demo/Home/Index
        // ROUTE: url / {area} / {controller} / {action}
        public IActionResult Index()
        {
            return Ok("Hello world");
        }
        // HTTP GET https://localhost:xxxx/Demo/Home/Index2
        public IActionResult Index2()
        {
            return View();
        }

        public IActionResult DisplayCustomer()
        {
            CustomerViewModel viewModel = new CustomerViewModel()
            {
                CustomerId = 1,
                CreatedOn = System.DateTime.Now
            };
            return View(viewModel);
        }

        // To address over-posting ensure that the [Bind] attribute lists all the needed properties.
        // NOTE: the names of the properties is CASE-SENSITIVE.
        // HTTP POST
        [HttpPost]
        [ValidateAntiForgeryToken]                      // to address JavaScript Injection Attacks
        public IActionResult DisplayCustomer(
            [Bind("CustomerId,CustomerName,Email,Balance")] CustomerViewModel viewModel)
        {
            return View(viewModel);
        }
    }
}
