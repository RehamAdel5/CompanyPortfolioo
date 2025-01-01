using CompanyPortfolioo.Interfaces;
using CompanyPortfolioo.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CompanyPortfolioo.Controllers
{
    public class ProjectDetailsController : Controller
    {
        private readonly IProjectDetailsService _projectDetailsService;
        public ProjectDetailsController(IProjectDetailsService projectDetailsService)
        {
            _projectDetailsService = projectDetailsService;
        }
        public async Task<IActionResult> Index(int id)
        {
            var (projectDetails, projectImages) = await _projectDetailsService.GetProjectDetailsAndImagesAsync(id); 
            if (projectDetails == null)
            {
                return View("NotFound");
            }
            ViewBag.ProjectImages = projectImages;
            return View(projectDetails);
        }
    }
}
