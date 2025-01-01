using CompanyPortfolioo.ViewModels;

namespace CompanyPortfolioo.Interfaces
{
    public interface IProjectsRepository
    {
        Task<List<ProjectViewModel>> GetProjectsAsync();
    }
}
