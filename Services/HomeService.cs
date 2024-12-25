using CompanyPortfolioo.Domain;
using CompanyPortfolioo.Interfaces;
using CompanyPortfolioo.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace CompanyPortfolioo.Services
{
    public class HomeService : IHomeService
    {
        private readonly ApplicationDbContext _context;
        public HomeService(ApplicationDbContext context)
        { _context = context; }
        public async Task<List<ServicesViewModel>> GetServicesAsync()
        {
            var services = await _context.Services.Select(s => new ServicesViewModel
            {
                Name = s.Name,
                Icon = s.Icon,
                Description = s.Description
            }).ToListAsync();
            return services;
        }

        public async Task<List<HorizontalSliderViewModel>> GetHorizontalSliderAsync()
        {
            var horizontalSliders = await _context.HorizontalSliders.Select(s => new HorizontalSliderViewModel
            {
                ImagePath = s.ImagePath
            }).ToListAsync();
            return horizontalSliders;
        }
        public async Task<List<AboutViewModel>> GetAboutAsync()
        {
            var aboutUs = await _context.AboutUs.Select(s => new AboutViewModel
            {
                Description = s.Description,
                Details = s.Details
            }).ToListAsync();
            return aboutUs;
        }
        public async Task<List<WhyUsViewModel>> GetWhyUsAsync()
        {
            var whyUs = await _context.WhyUs.Select(s => new WhyUsViewModel
            {
                Question = s.Question,
                Answer = s.Answer
            }).ToListAsync();
            return whyUs;
        }
        public async Task<List<SkillsViewModel>> GetSkillsAsync()
        {
            var skills = await _context.Skills.Select(s => new SkillsViewModel
            {
                Name = s.Name,
                ProgressPercent = s.ProgressPercent
            }).ToListAsync();
            return skills;
        }
        public async Task<List<ProjectViewModel>> GetProjectsAsync()
        {
            var projects = await _context.Projects.Select(s => new ProjectViewModel
            {
                Name = s.Name,
                Bio = s.Bio,
                MainImagePath = s.MainImagePath,
                ProjectCategoryId = s.ProjectCategoryId,
                ProjectCategoryName = s.ProjectCategory.Name,
                ProjectCategoryDescription = s.ProjectCategory.Description
            }).ToListAsync();
            return projects;
        }
        public async Task<List<TeamViewModel>> GetTeamAsync()
        {
            var teams = await _context.Teams.Select(s => new TeamViewModel
            {
                Name = s.Name,
                Summary = s.Summary,
                PositionTitle = s.PositionTitle,
                ImagePath = s.ImagePath,
                FacebookUrl = s.FacebookUrl,
                InstagramUrl = s.InstagramUrl,
                LinkedInUrl = s.LinkedInUrl,
                TwitterUrl = s.TwitterUrl
            }).ToListAsync();
            return teams;
        }
        public async Task<List<PricingViewModel>> GetFeaturesAsync()
        {
            var features = await _context.Features.Select(s => new PricingViewModel
            {
                PlanName = s.Pricing.PlanName,
                Price = s.Pricing.Price,
                IsActive = s.Pricing.IsActive,
                Title = s.Title,
                IsActiveFeature = s.IsActiveFeature,
                FeatureId = s.Id,
                PriceId = s.Pricing.Id
            }).ToListAsync();
            return features;
        }
        public async Task<List<TestimonialViewModel>> GetTestimonialAsync()
        {
            var testimonials = await _context.Testimonials.Select(s => new TestimonialViewModel
            {
                Name = s.Name,
                PositionTitle = s.PositionTitle,
                ImagePath = s.ImagePath,
                ClientOpinion = s.ClientOpinion,
                Stars = s.Stars
            }).ToListAsync();
            return testimonials;
        }
        public async Task<List<AskedQuestionViewModel>> GetAskedQuestionAsync()
        {
            var askedQuestions = await _context.AskedQuestions.Select(s => new AskedQuestionViewModel
            {
                Question = s.Question,
                Answer = s.Answer
            }).ToListAsync();
            return askedQuestions;
        }
        public async Task<List<ContactUsViewModel>> GetContactUsAsync()
        {
            var contactUs = await _context.ContactUs.Select(s => new ContactUsViewModel
            {
                Address = s.Address,
                Email = s.Email,
                FacebookUrl = s.FacebookUrl,
                InstagramUrl = s.InstagramUrl,
                Latitude = s.Latitude,
                LinkedInUrl = s.LinkedInUrl,
                Longitude = s.Longitude,
                Phone = s.Phone,
                TwitterUrl = s.TwitterUrl
            }).ToListAsync();
            return contactUs;
        }

    }
}
