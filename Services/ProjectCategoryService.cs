using CompanyPortfolioo.Domain;
using CompanyPortfolioo.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CompanyPortfolioo.Services
{
    public class ProjectCategoryService : IProjectCategoryService
    {
        private readonly ApplicationDbContext _context;
        public ProjectCategoryService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<List<ProjectCategory>> GetProjectCategoriesAsync()
        {
            var projectCategoryList = await _context.ProjectCategories.ToListAsync();
            return projectCategoryList;
        }
    }
}
