using AutoMapper;
using CompanyPortfolioo.Domain;
using CompanyPortfolioo.Interfaces;
using CompanyPortfolioo.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace CompanyPortfolioo.Services
{
    public class FeaturesRepository : IFeaturesRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public FeaturesRepository(ApplicationDbContext context,IMapper mapper)
        { 
            _context = context;
            _mapper = mapper;
        }
        public async Task<List<PricingViewModel>> GetFeaturesAsync()
        {
            var features = await _context.Features.Include(f => f.Pricing).ToListAsync(); 
            return _mapper.Map<List<PricingViewModel>>(features);

        }
    }
}
