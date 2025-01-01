using CompanyPortfolioo.Domain;
using CompanyPortfolioo.Interfaces;
using CompanyPortfolioo.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace CompanyPortfolioo.Services
{
    public class TeamRepository : ITeamRepository 
    {
        private readonly ApplicationDbContext _context;
        public TeamRepository(ApplicationDbContext context)
        { 
            _context = context; 
        } 
        public async Task<List<TeamViewModel>> GetTeamAsync()
        {
            return await _context.Teams.Select(s => new TeamViewModel
            { Name = s.Name,
                Summary = s.Summary,
                PositionTitle = s.PositionTitle, 
                ImagePath = s.ImagePath,
                FacebookUrl = s.FacebookUrl,
                InstagramUrl = s.InstagramUrl,
                LinkedInUrl = s.LinkedInUrl,
                TwitterUrl = s.TwitterUrl
            }).ToListAsync(); } }
}
