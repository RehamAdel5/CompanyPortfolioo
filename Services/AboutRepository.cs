using CompanyPortfolioo.Domain;
using CompanyPortfolioo.Interfaces;
using CompanyPortfolioo.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace CompanyPortfolioo.Services
{
    public class AboutRepository : IAboutRepository
    {
        private readonly ApplicationDbContext _context; public AboutRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<List<AboutViewModel>> GetAboutAsync()
        {
            return await _context.AboutUs.Select(s => new AboutViewModel
            {
                Description = s.Description,
                Details = s.Details
            }).ToListAsync();
        }
    }
}