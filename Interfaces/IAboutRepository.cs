using CompanyPortfolioo.ViewModels;

namespace CompanyPortfolioo.Interfaces
{
    public interface IAboutRepository
    {
        Task<List<AboutViewModel>> GetAboutAsync();
    }
}
