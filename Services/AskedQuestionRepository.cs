using AutoMapper;
using CompanyPortfolioo.Domain;
using CompanyPortfolioo.Interfaces;
using CompanyPortfolioo.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace CompanyPortfolioo.Services
{
    public class AskedQuestionRepository : IAskedQuestionRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public AskedQuestionRepository(ApplicationDbContext context, IMapper mapper)
        { _context = context;
            _mapper = mapper;
        }
        public async Task<List<AskedQuestionsViewModel>> GetAskedQuestionAsync()
        {
          
             var askedQuestions=   await _context.AskedQuestions.ToListAsync();
            return _mapper.Map<List<AskedQuestionsViewModel>>(askedQuestions);
        }
    }
}
