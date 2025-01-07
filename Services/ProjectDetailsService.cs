using CompanyPortfolioo.Domain;
using CompanyPortfolioo.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CompanyPortfolioo.Services
{
    public class ProjectDetailsService : IProjectDetailsService
    {
        private readonly ApplicationDbContext _context;
        public ProjectDetailsService(ApplicationDbContext context)
        {
            _context = context; 
        }
        public async Task<(ProjectDetails, List<ProjectImage>)> GetProjectDetailsAndImagesAsync(int id)
        {
            var projectDetails = await _context.ProjectDetails.Include(pd => pd.Project)
                .ThenInclude(p => p.ProjectCategory)
                .Include(pd => pd.Testimonial)
                .FirstOrDefaultAsync(pd => pd.Id == id);
            if (projectDetails != null)
            {
                var projectImages = await _context.ProjectImages.Where(pi => pi.ProjectId == projectDetails.ProjectId).Select(pi => new ProjectImage
                {
                    Id = pi.Id,
                    ImagePath = pi.ImagePath
                })
            .ToListAsync();
                return (projectDetails, projectImages);
            }
            return (null, null);


        }
    }
}
