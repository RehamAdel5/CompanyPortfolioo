using CompanyPortfolioo.Domain;
using CompanyPortfolioo.Interfaces;
using CompanyPortfolioo.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace CompanyPortfolioo.Services
{
    public class FeaturesRepository : IFeaturesRepository
    {
        private readonly ApplicationDbContext _context;

        public FeaturesRepository(ApplicationDbContext context)
        { _context = context; }
        public async Task<List<PricingViewModel>> GetFeaturesAsync()
        {
            return await _context.Features.Select(s => new PricingViewModel
            {
                PlanName = s.Pricing.PlanName,
                Price = s.Pricing.Price,
                IsActive = s.Pricing.IsActive,
                Title = s.Title,
                IsActiveFeature = s.IsActiveFeature,
                FeatureId = s.Id,
                PriceId = s.Pricing.Id
            }).ToListAsync();
        }
    }
}
