using CompanyPortfolioo.Domain;
using CompanyPortfolioo.Interfaces;
using CompanyPortfolioo.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace CompanyPortfolioo.Services
{

    public class ServicesRepository : IServicesRepository
    {
        private readonly ApplicationDbContext _context;
        public ServicesRepository(ApplicationDbContext context)
        { _context = context; }
        public async Task<List<ServicesViewModel>> GetServicesAsync()
        {
            return await _context.Services.Select(s => new ServicesViewModel
            {
                Name = s.Name,
                Icon = s.Icon,
                Description = s.Description
            }).ToListAsync();
        }
    }
}

