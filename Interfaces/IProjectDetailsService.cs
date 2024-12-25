using CompanyPortfolioo.Domain;

namespace CompanyPortfolioo.Interfaces
{
    public interface IProjectDetailsService
    {
        Task<List<ProjectDetails>> GetProjectDetailsAsync();
    }
}
