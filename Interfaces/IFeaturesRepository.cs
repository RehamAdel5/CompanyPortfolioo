using CompanyPortfolioo.ViewModels;

namespace CompanyPortfolioo.Interfaces
{
    public interface IFeaturesRepository
    {
        Task<List<PricingViewModel>> GetFeaturesAsync();
    }
}
