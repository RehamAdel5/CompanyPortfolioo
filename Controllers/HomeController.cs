using CompanyPortfolioo.Domain;
using CompanyPortfolioo.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Build.ObjectModelRemoting;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.Blazor;

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
            var services = GetServices();
            var slider = GetHorizontalSlider();
            var about = GetAbout();
            var whyUs = GetWhyUs();
            var skills = GetSkills();
            var projects = GetProjects();
            var team = GetTeam();
            var featuresList = GetFeatures();
            var testimonial = GetTestimonial();
            var askedQuestion = GetAskedQuestion();
            var  contactUs= GetContactUs(); 
            var viewModel = new IndexViewModel
            {
                ServicesList = services,
                HorizontalSliderList = slider,
                AboutList = about,
                WhyUsList = whyUs,
                SkillsList = skills,
                ProjectList = projects,
                TeamList = team,
                FeaturesList = featuresList,
                TestimonialList = testimonial,
                AskedQuestionList = askedQuestion,
                ContactUsList= contactUs
            };

            ViewBag.ProjectCategories = projects.Select(p =>
            new { p.ProjectCategoryId, p.ProjectCategoryName }).Distinct().ToList();

            ViewBag.PricingList = featuresList.Select(p =>
            new { p.PlanName, p.Price, p.PriceId }).Distinct().ToList();

            return View(viewModel);
        }
        public IActionResult CompanyInformation()
        {
            return PartialView("_CompanyInformation");

        }
        public IActionResult Clients()
        {
            var sliderItems = GetHorizontalSlider();
            return PartialView("_Clients", sliderItems);
        }
        public IActionResult About()
        {
            var about = GetAbout();
            return PartialView("_About", about);
        }
        public IActionResult WhyUs()
        {
            var whyUs = GetWhyUs();
            return PartialView("_WhyUs", whyUs);
        }
        public IActionResult Skills()
        {
            var skills = GetSkills();
            return PartialView("_Skills", skills);
        }
        public IActionResult Services()
        {
            var services = GetServices();

            return PartialView("_Services", services);
        }

        public IActionResult CallToAction()
        {
            return PartialView("_CallToAction");
        }
        public IActionResult Portfolio()
        {
            var projects = GetProjects();
            return PartialView("_Portfolio", projects);
        }
        public IActionResult Team()
        {
            var teamList = GetTeam();
            return PartialView("_Team", teamList);
        }
        public IActionResult Pricing()
        {
            var featuresList = GetFeatures();

            return PartialView("_Pricing", featuresList);
        }
        public IActionResult Testimonials()
        {
            var testimonialList = GetTestimonial();
            return PartialView("_Testimonials", testimonialList);
        }

        public IActionResult AskedQuestion()
        {
            var question = GetAskedQuestion();
            return PartialView("_AskedQuestion", question);
        }
        public IActionResult ContactUs()
        { var contactUs = GetContactUs();
            return PartialView("_ContactUs", contactUs);
        }


        #region --- Filling Lists for partial ----
        private List<ServicesViewModel> GetServices()
        {
            var services = _context.Services.Select(s => new ServicesViewModel
            {
                Name = s.Name,
                Icon = s.Icon,
                Description = s.Description
            }).ToList() ?? new List<ServicesViewModel>();

            return services;
        }

        private List<HorizontalSliderViewModel> GetHorizontalSlider()
        {
            var sliderItems = _context.HorizontalSliders.Select(s => new HorizontalSliderViewModel
            {
                ImagePath = s.ImagePath
            }).ToList() ?? new List<HorizontalSliderViewModel>();

            return sliderItems;
        }

        private List<AboutViewModel> GetAbout()
        {
            var about = _context.AboutUs.Select(s => new AboutViewModel
            {
                Description = s.Description,
                Details = s.Details,

            }).ToList() ?? new List<AboutViewModel>();

            return about;
        }
        private List<WhyUsViewModel> GetWhyUs()
        {
            var whyUs = _context.WhyUs.Select(s => new WhyUsViewModel
            {
                Question = s.Question,
                Answer = s.Answer,

            }).ToList() ?? new List<WhyUsViewModel>();

            return whyUs;
        }
        private List<SkillsViewModel> GetSkills()
        {
            var skills = _context.Skills.Select(s => new SkillsViewModel
            {
                Name = s.Name,
                ProgressPercent = s.ProgressPercent,

            }).ToList() ?? new List<SkillsViewModel>();

            return skills;
        }
        private List<ProjectViewModel> GetProjects()
        {
            var projects = _context.Projects.Select(s => new ProjectViewModel
            {
                Name = s.Name,
                Bio = s.Bio,
                MainImagePath = s.MainImagePath,
                ProjectCategoryId = s.ProjectCategoryId,
                ProjectCategoryName = s.ProjectCategory.Name,
                ProjectCategoryDescription = s.ProjectCategory.Description,

            }).ToList() ?? new List<ProjectViewModel>();

            return projects;
        }
        private List<TeamViewModel> GetTeam()
        {
            var TeamList = _context.Teams.Select(s => new TeamViewModel
            {
                Name = s.Name,
                Summary = s.Summary,
                PositionTitle = s.PositionTitle,
                ImagePath = s.ImagePath,
                FacebookUrl = s.FacebookUrl,
                InstagramUrl = s.InstagramUrl,
                LinkedInUrl = s.LinkedInUrl,
                TwitterUrl = s.TwitterUrl



            }).ToList() ?? new List<TeamViewModel>();

            return TeamList;
        }
        private List<PricingViewModel> GetFeatures()
        {
            var FeaturesList = _context.Features.Select(s => new PricingViewModel
            {
                PlanName = s.Pricing.PlanName,
                Price = s.Pricing.Price,
                IsActive = s.Pricing.IsActive,
                Title = s.Title,
                IsActiveFeature = s.IsActiveFeature,
                FeatureId = s.Id,
                PriceId = s.Pricing.Id
            }).ToList() ?? new List<PricingViewModel>();

            return FeaturesList;
        }
        private List<TestimonialViewModel> GetTestimonial()
        {
            var TestimonialList = _context.Testimonials.Select(s => new TestimonialViewModel
            {
                Name = s.Name,
                PositionTitle = s.PositionTitle,
                ImagePath = s.ImagePath,
                ClientOpinion = s.ClientOpinion,
                Stars = s.Stars,
            }).ToList() ?? new List<TestimonialViewModel>();

            return TestimonialList;
        }
        private List<AskedQuestionViewModel> GetAskedQuestion()
        {
            var AskedQuestionList = _context.AskedQuestions.Select(s => new AskedQuestionViewModel
            {
                Question = s.Question,
                Answer = s.Answer,
            }).ToList() ?? new List<AskedQuestionViewModel>();

            return AskedQuestionList;
        }
        private List<ContactUsViewModel> GetContactUs()
        {
            var contactUsList = _context.ContactUs.Select(s => new ContactUsViewModel
            {
                Address = s.Address,
                Email = s.Email,
                FacebookUrl = s.FacebookUrl,
                InstagramUrl = s.InstagramUrl,
                Latitude = s.Latitude,
                LinkedInUrl = s.LinkedInUrl,
                Longitude = s.Longitude,
                Phone = s.Phone,
                TwitterUrl = s.TwitterUrl,
                
               
            }).ToList() ?? new List<ContactUsViewModel>();

            return contactUsList;
        }
        #endregion
    }
}
