using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SchoolDesignBrief1.Models;

namespace SchoolDesignBrief1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> logger;
        private readonly Database database;

        [TempData] 
        public string SuccessMessage { get; set; }

        public HomeController(ILogger<HomeController> logger, Database database)
        {
            this.logger = logger;
            this.database = database;
        }

        [HttpGet, Route("", Name = "root")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet, Route("privacy")]
        public IActionResult Privacy()
        {
            return View();
        }

        [HttpGet, Route("mvc/contact")]
        public IActionResult Contact()
        {
            return View(new ContactModel {
                SuccessMessage = SuccessMessage
            });
        }

        [HttpPost, Route("mvc/contact")]
        public IActionResult Contact([FromForm] ContactModel model)
        {
            if (ModelState.IsValid)
            {
                database.AddContactDbSet(model);
                //database.AddClassDbSet(model);
                SuccessMessage = "MVC Thank you for contacting us!";
                
                logger.LogInformation("Contact form submitted: {Message}", model);
                
                return RedirectToAction(nameof(Contact));
            }

            return View(model);
        }

        [HttpGet, Route("mvc/class")]
        public IActionResult Class()
        {
            return View(new ClassModel { 
                SuccessMessage = SuccessMessage
            });
        }

        [HttpPost, Route("mvc/class")]
        public IActionResult Class([FromForm] ClassModel model)
        {
            if (ModelState.IsValid)
            {
                database.AddClassDbSet(model);

                SuccessMessage = "MVC Thank you for contacting us!";

                logger.LogInformation("Class form submitted: {Message}", model);

                return RedirectToAction(nameof(Class));
            }

            return View(model);
        }

        [HttpGet, Route("error")]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}