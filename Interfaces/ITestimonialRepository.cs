using CompanyPortfolioo.ViewModels;

namespace CompanyPortfolioo.Interfaces
{
    public interface ITestimonialRepository
    {
        Task<List<TestimonialViewModel>> GetTestimonialAsync();
    }
}
