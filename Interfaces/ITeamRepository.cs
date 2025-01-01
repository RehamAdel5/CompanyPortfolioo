using CompanyPortfolioo.ViewModels;

namespace CompanyPortfolioo.Interfaces
{
    public interface ITeamRepository
    {
        Task<List<TeamViewModel>> GetTeamAsync();
    }
}
