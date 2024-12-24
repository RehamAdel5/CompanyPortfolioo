using CompanyPortfolioo.Domain;
using CompanyPortfolioo.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Internal;
using System.Collections.Frozen;

namespace CompanyPortfolioo.Controllers
{
    public class ProjectCategoryController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProjectCategoryController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var categoryList = _context.ProjectCategories.ToList();

            ViewBag.CategoryNames = categoryList.Select(p =>
            new { p.Id, p.Name }).Distinct().ToList();

            return View(categoryList);
        }
        public IActionResult GetProjectCategory()
        {
            //var ProjectcategoryList = _context.Projects.Select(s => new ProjectCategoryViewModel
            //{
            //    CategoryName = s.Name,
            //   Description = s.ProjectCategory.Description,
            //   MainImagePath=s.MainImagePath,
            //   ProjectBio=s.Bio,
            //   ProjectName=s.Name,

            //}).ToList() ?? new List<ProjectCategoryViewModel>();

            return View();
        }
    }
}
