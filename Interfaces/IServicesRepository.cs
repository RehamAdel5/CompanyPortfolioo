using CompanyPortfolioo.ViewModels;

namespace CompanyPortfolioo.Interfaces
{
    public interface IServicesRepository
    {
        Task<List<ServicesViewModel>> GetServicesAsync();
    }
}
