using CompanyPortfolioo.Domain;
using CompanyPortfolioo.Interfaces;
using CompanyPortfolioo.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Internal;
using System.Collections.Frozen;

namespace CompanyPortfolioo.Controllers
{
    public class ProjectCategoryController : Controller
    {
        private readonly IProjectCategoryService _projectCategoryService;
        public ProjectCategoryController(IProjectCategoryService projectCategoryService)
        { _projectCategoryService = projectCategoryService; }
        public async Task<IActionResult> Index()
        {
            var categoryList = await _projectCategoryService.GetProjectCategoriesAsync();
            ViewBag.CategoryNames = categoryList.Select(p => new
            {
                p.Id,
                p.Name
            }).Distinct().ToList();
            return View(categoryList);
        }
        public IActionResult GetProjectCategory() {
           
            return View(); 
        
        }
    }
}