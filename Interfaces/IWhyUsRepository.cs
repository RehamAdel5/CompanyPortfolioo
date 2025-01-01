using CompanyPortfolioo.ViewModels;

namespace CompanyPortfolioo.Interfaces
{
    public interface IWhyUsRepository
    {
        Task<List<WhyUsViewModel>> GetWhyUsAsync();
    }
}
