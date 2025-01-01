using CompanyPortfolioo.ViewModels;

namespace CompanyPortfolioo.Interfaces
{
    public interface IContactUsRepository
    {
        Task<ContactUsViewModel> GetContactUsAsync();
    }
}
