using CompanyPortfolioo.Domain;
using CompanyPortfolioo.Interfaces;
using CompanyPortfolioo.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace CompanyPortfolioo.Services
{
    public class SkillsRepository : ISkillsRepository
    {
        private readonly ApplicationDbContext _context;
        public SkillsRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<List<SkillsViewModel>> GetSkillsAsync()
        {
            return await _context.Skills.Select(s => new SkillsViewModel
            {
                Name = s.Name,
                ProgressPercent = s.ProgressPercent
            }).ToListAsync();
        }
    }
}
