using CompanyPortfolioo.Domain;
using CompanyPortfolioo.Interfaces;
using CompanyPortfolioo.Services;
using CompanyPortfolioo.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Build.ObjectModelRemoting;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.Blazor;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages;

namespace HomeController.Controllers
{
    public class HomeController : Controller
    {
        
    private readonly IHomeService _homeService;

        public HomeController(IHomeService homeService)
        {
            _homeService = homeService;
        }

        public async Task<IActionResult> Index()
        {
            var services = await _homeService.GetServicesAsync();
            var slider = await _homeService.GetHorizontalSliderAsync();
            var about = await _homeService.GetAboutAsync();
            var whyUs = await _homeService.GetWhyUsAsync();
            var skills = await _homeService.GetSkillsAsync();
            var projects = await _homeService.GetProjectsAsync();
            var team = await _homeService.GetTeamAsync();
            var featuresList = await _homeService.GetFeaturesAsync();
            var testimonial = await _homeService.GetTestimonialAsync();
            var askedQuestion = await _homeService.GetAskedQuestionAsync();
            var contactUs = await _homeService.GetContactUsAsync();

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
                ContactUsList = contactUs
            };

            ViewBag.ProjectCategories = projects
                .Select(p => new { p.ProjectCategoryId, p.ProjectCategoryName })
                .Distinct().ToList();

            ViewBag.PricingList = featuresList
                .Select(p => new { p.PlanName, p.Price, p.PriceId })
                .Distinct().ToList();

            return View(viewModel);
        }

      

        public async Task<IActionResult> Clients()
        {
            var sliderItems = await _homeService.GetHorizontalSliderAsync();
            return PartialView("_Clients", sliderItems);
        }

        public async Task<IActionResult> About()
        {
            var about = await _homeService.GetAboutAsync();
            return PartialView("_About", about);
        }

        public async Task<IActionResult> WhyUs()
        {
            var whyUs = await _homeService.GetWhyUsAsync();
            return PartialView("_WhyUs", whyUs);
        }

        public async Task<IActionResult> Skills()
        {
            var skills = await _homeService.GetSkillsAsync();
            return PartialView("_Skills", skills);
        }

        public async Task<IActionResult> Services()
        {
            var services = await _homeService.GetServicesAsync();
            return PartialView("_Services", services);
        }

        public IActionResult CallToAction()
        {
            return PartialView("_CallToAction");
        }

        public async Task<IActionResult> Portfolio()
        {
            var projects = await _homeService.GetProjectsAsync();
            return PartialView("_Portfolio", projects);
        }

        public async Task<IActionResult> Team()
        {
            var teamList = await _homeService.GetTeamAsync();
            return PartialView("_Team", teamList);
        }

        public async Task<IActionResult> Pricing()
        {
            var featuresList = await _homeService.GetFeaturesAsync();
            return PartialView("_Pricing", featuresList);
        }

        public async Task<IActionResult> Testimonials()
        {
            var testimonialList = await _homeService.GetTestimonialAsync();
            return PartialView("_Testimonials", testimonialList);
        }

        public async Task<IActionResult> AskedQuestion()
        {
            var question = await _homeService.GetAskedQuestionAsync();
            return PartialView("_AskedQuestion", question);
        }

        public async Task<IActionResult> ContactUs()
        {
            var contactUs = await _homeService.GetContactUsAsync();
            return PartialView("_ContactUs", contactUs);
        }
    }
  
    }
    




   
