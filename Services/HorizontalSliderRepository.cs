using CompanyPortfolioo.Domain;
using CompanyPortfolioo.Interfaces;
using CompanyPortfolioo.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace CompanyPortfolioo.Services
{
    public class HorizontalSliderRepository : IHorizontalSliderRepository
    {
        private readonly ApplicationDbContext _context;
        public HorizontalSliderRepository(ApplicationDbContext context)
        { _context = context;
        }
        public async Task<List<HorizontalSliderViewModel>> GetHorizontalSliderAsync()
        {
            return await _context.HorizontalSliders.Select(s => new HorizontalSliderViewModel
            {
                ImagePath = s.ImagePath
            }).ToListAsync();
        }
    }
}
