using CompanyPortfolioo.Domain;
using CompanyPortfolioo.Interfaces;
using CompanyPortfolioo.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace CompanyPortfolioo.Services
{
    public class WhyUsRepository : IWhyUsRepository 
    {
        private readonly ApplicationDbContext _context; 
        public WhyUsRepository(ApplicationDbContext context) 
        { _context = context; } public async Task<List<WhyUsViewModel>> GetWhyUsAsync() 
        { 
            return await _context.WhyUs.Select(s => new WhyUsViewModel 
            {
                Question = s.Question,
                Answer = s.Answer 
    }).ToListAsync(); } }
}
