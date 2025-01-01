using CompanyPortfolioo.Domain;
using CompanyPortfolioo.Interfaces;
using CompanyPortfolioo.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace CompanyPortfolioo.Services
{
}
public class TestimonialRepository : ITestimonialRepository
{
    private readonly ApplicationDbContext _context;
    public TestimonialRepository(ApplicationDbContext context)
    {
        _context = context;
    }
    public async Task<List<TestimonialViewModel>> GetTestimonialAsync()
    {
        return await _context.Testimonials.Select(s => new TestimonialViewModel
        {
            Name = s.Name,
            PositionTitle = s.PositionTitle,
            ImagePath = s.ImagePath,
            ClientOpinion = s.ClientOpinion,
            Stars = s.Stars
        }).ToListAsync();
    }
}
