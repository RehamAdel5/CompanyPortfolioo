using CompanyPortfolioo.ViewModels;

namespace CompanyPortfolioo.Interfaces
{
    public interface IAskedQuestionRepository
    {
        Task<List<AskedQuestionsViewModel>> GetAskedQuestionAsync();
    }
}
