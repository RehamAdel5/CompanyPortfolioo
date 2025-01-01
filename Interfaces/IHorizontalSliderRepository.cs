using CompanyPortfolioo.ViewModels;

namespace CompanyPortfolioo.Interfaces
{
    public interface IHorizontalSliderRepository
    {
        Task<List<HorizontalSliderViewModel>> GetHorizontalSliderAsync();
    }
}
