using CompanyPortfolioo.Domain;

namespace CompanyPortfolioo.Interfaces
{
    public interface IProjectCategoryService
    {
        Task<List<ProjectCategory>> GetProjectCategoriesAsync();
    }
}
