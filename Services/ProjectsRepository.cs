using CompanyPortfolioo.Domain;
using CompanyPortfolioo.Interfaces;
using CompanyPortfolioo.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace CompanyPortfolioo.Services
{

    public class ProjectsRepository : IProjectsRepository
    {
        private readonly ApplicationDbContext _context;
        public ProjectsRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<List<ProjectViewModel>> GetProjectsAsync()
        {
            return await _context.Projects.Select(s => new ProjectViewModel
            {
                Name = s.Name,
                Bio = s.Bio,
                MainImagePath = s.MainImagePath
                ,
                ProjectCategoryId = s.ProjectCategoryId
                ,
                ProjectCategoryName = s.ProjectCategory.Name,
                ProjectCategoryDescription = s.ProjectCategory.Description
            }).ToListAsync();
        }
    }
}

