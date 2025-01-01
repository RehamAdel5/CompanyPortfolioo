using CompanyPortfolioo.Domain;
using CompanyPortfolioo.Interfaces;
using CompanyPortfolioo.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace CompanyPortfolioo.Services
{
    public class AskedQuestionRepository : IAskedQuestionRepository
    {
        private readonly ApplicationDbContext _context;
        public AskedQuestionRepository(ApplicationDbContext context)
        { _context = context; 
        }
        public async Task<List<AskedQuestionsViewModel>> GetAskedQuestionAsync()
        {
            return await _context.AskedQuestions.Select(s => new AskedQuestionsViewModel
            {
                Question = s.Question,
                Answer = s.Answer
            }).ToListAsync();
        }
    }
}
