using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CompanyPortfolioo.Domain;

namespace CompanyPortfolioo.Controllers
{
    public class ProjectDetails1Controller : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProjectDetails1Controller(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ProjectDetails1
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.ProjectDetails.Include(p => p.Project).Include(p => p.Testimonial);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: ProjectDetails1/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var projectDetails = await _context.ProjectDetails
                .Include(p => p.Project)
                .Include(p => p.Testimonial)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (projectDetails == null)
            {
                return NotFound();
            }

            return View(projectDetails);
        }

        // GET: ProjectDetails1/Create
        public IActionResult Create()
        {
            ViewData["ProjectId"] = new SelectList(_context.Projects, "Id", "Id");
            ViewData["TestimonialId"] = new SelectList(_context.Testimonials, "Id", "Id");
            return View();
        }

        // POST: ProjectDetails1/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,StartDate,EndDate,URL,Description,ProjectId,TestimonialId")] ProjectDetails projectDetails)
        {
            if (ModelState.IsValid)
            {
                _context.Add(projectDetails);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ProjectId"] = new SelectList(_context.Projects, "Id", "Id", projectDetails.ProjectId);
            ViewData["TestimonialId"] = new SelectList(_context.Testimonials, "Id", "Id", projectDetails.TestimonialId);
            return View(projectDetails);
        }

        // GET: ProjectDetails1/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var projectDetails = await _context.ProjectDetails.FindAsync(id);
            if (projectDetails == null)
            {
                return NotFound();
            }
            ViewData["ProjectId"] = new SelectList(_context.Projects, "Id", "Id", projectDetails.ProjectId);
            ViewData["TestimonialId"] = new SelectList(_context.Testimonials, "Id", "Id", projectDetails.TestimonialId);
            return View(projectDetails);
        }

        // POST: ProjectDetails1/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,StartDate,EndDate,URL,Description,ProjectId,TestimonialId")] ProjectDetails projectDetails)
        {
            if (id != projectDetails.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(projectDetails);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProjectDetailsExists(projectDetails.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["ProjectId"] = new SelectList(_context.Projects, "Id", "Id", projectDetails.ProjectId);
            ViewData["TestimonialId"] = new SelectList(_context.Testimonials, "Id", "Id", projectDetails.TestimonialId);
            return View(projectDetails);
        }

        // GET: ProjectDetails1/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var projectDetails = await _context.ProjectDetails
                .Include(p => p.Project)
                .Include(p => p.Testimonial)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (projectDetails == null)
            {
                return NotFound();
            }

            return View(projectDetails);
        }

        // POST: ProjectDetails1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var projectDetails = await _context.ProjectDetails.FindAsync(id);
            if (projectDetails != null)
            {
                _context.ProjectDetails.Remove(projectDetails);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProjectDetailsExists(int id)
        {
            return _context.ProjectDetails.Any(e => e.Id == id);
        }
    }
}
