using CompanyPortfolioo.Domain;

namespace CompanyPortfolioo.Interfaces
{
    public interface IProjectDetailsService
    {
        Task<(ProjectDetails, List<ProjectImage>)> GetProjectDetailsAndImagesAsync(int id);

    }
}
