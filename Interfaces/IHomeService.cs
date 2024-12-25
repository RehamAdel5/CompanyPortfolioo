using CompanyPortfolioo.ViewModels;

namespace CompanyPortfolioo.Interfaces
{
    public interface IHomeService
    {
        Task<List<ServicesViewModel>> GetServicesAsync(); 
        Task<List<HorizontalSliderViewModel>> GetHorizontalSliderAsync();
        Task<List<AboutViewModel>> GetAboutAsync();
        Task<List<WhyUsViewModel>> GetWhyUsAsync();
        Task<List<SkillsViewModel>> GetSkillsAsync(); 
        Task<List<ProjectViewModel>> GetProjectsAsync(); 
        Task<List<TeamViewModel>> GetTeamAsync();
        Task<List<PricingViewModel>> GetFeaturesAsync(); 
        Task<List<TestimonialViewModel>> GetTestimonialAsync(); 
        Task<List<AskedQuestionViewModel>> GetAskedQuestionAsync();
        Task<List<ContactUsViewModel>> GetContactUsAsync();
    }
}
