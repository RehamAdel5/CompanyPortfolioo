using AutoMapper;
using CompanyPortfolioo.Domain;
using CompanyPortfolioo.Interfaces;
using CompanyPortfolioo.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace CompanyPortfolioo.Services
{
    public class TeamRepository : ITeamRepository 
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public TeamRepository(ApplicationDbContext context,IMapper mapper)
        { 
            _context = context;
            _mapper = mapper;
        } 
        public async Task<List<TeamViewModel>> GetTeamAsync()
        {
        var team= await _context.Teams.ToListAsync();
            return _mapper.Map<List<TeamViewModel>>(team);



        }
    }
}
