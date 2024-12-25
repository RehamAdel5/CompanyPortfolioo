using CompanyPortfolioo.Interfaces;
using CompanyPortfolioo.Services;
using Microsoft.AspNetCore.Mvc;

namespace CompanyPortfolioo.Controllers
{
    public class ProjectDetailsController : Controller
    {
        private readonly IProjectDetailsService _projectDetailsService;
        public ProjectDetailsController(IProjectDetailsService projectDetailsService)
        {
            _projectDetailsService = projectDetailsService;
        }
        public async Task<IActionResult> Index()
        {
            var projectDetailsList = await _projectDetailsService.GetProjectDetailsAsync();
            return View(projectDetailsList);
        }
    }
}
