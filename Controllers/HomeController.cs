using CompanyPortfolioo.Domain;
using CompanyPortfolioo.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace HomeController.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CompanyInformation()
        {
            return PartialView("_CompanyInformation");

        }
        public IActionResult Clients()
        {
            return PartialView("_Clients");
        }
        public IActionResult About()
        {
            return PartialView("_About");
        }
        public IActionResult WhyUs()
        {
            return PartialView("_WhyUs");
        }
        public IActionResult Skills()
        {
            return PartialView("_Skills");
        }
        public IActionResult Services()
        {
            var services = _context.Services.Select(s => new ServicesViewModel
            {
                Name = s.Name,
                Description = s.Description,
                Icon = s.Icon,


            }).ToList();
            

            return View(services);
        }


        public IActionResult CallToAction()
        {
            return PartialView("_CallToAction");
        }
        public IActionResult Portfolio()
        {
            return PartialView("_Portfolio");
        }
        public IActionResult Team()
        {
            return PartialView("_Team");
        }
        public IActionResult Pricing()
        {
            return PartialView("_Pricing");
        }
        public IActionResult Testimonials()
        {
            return PartialView("_Testimonials");
        }
        
         public IActionResult AskedQuestion()
        {
            return PartialView("_AskedQuestion");
        }
        public IActionResult ContactUs()
        {
            return PartialView("_ContactUs");
        }
    }
}
