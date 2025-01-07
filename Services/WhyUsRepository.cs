using AutoMapper;
using CompanyPortfolioo.Domain;
using CompanyPortfolioo.Interfaces;
using CompanyPortfolioo.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace CompanyPortfolioo.Services
{
    public class WhyUsRepository : IWhyUsRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public WhyUsRepository(ApplicationDbContext context,IMapper mapper)
        {
            _context = context;
           _mapper = mapper;
        }
        public async Task<List<WhyUsViewModel>> GetWhyUsAsync()
        {
          var whyUs =  await _context.WhyUs.ToListAsync();
            return _mapper.Map<List<WhyUsViewModel>>(whyUs);

        }
    }
}
