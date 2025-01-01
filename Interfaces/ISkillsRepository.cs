using CompanyPortfolioo.ViewModels;

namespace CompanyPortfolioo.Interfaces
{
    public interface ISkillsRepository
    {
        Task<List<SkillsViewModel>> GetSkillsAsync();
    }
}
