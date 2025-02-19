﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CompanyPortfolioo.Domain;

namespace CompanyPortfolioo.Controllers
{
    public class ProjectCategoriesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProjectCategoriesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ProjectCategories
        public async Task<IActionResult> Index()
        {
            return View(await _context.ProjectCategories.ToListAsync());
        }

        // GET: ProjectCategories/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var projectCategory = await _context.ProjectCategories
                .FirstOrDefaultAsync(m => m.Id == id);
            if (projectCategory == null)
            {
                return NotFound();
            }

            return View(projectCategory);
        }

        // GET: ProjectCategories/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ProjectCategories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Description,ImagePath")] ProjectCategory projectCategory)
        {
            if (ModelState.IsValid)
            {
                _context.Add(projectCategory);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(projectCategory);
        }

        // GET: ProjectCategories/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var projectCategory = await _context.ProjectCategories.FindAsync(id);
            if (projectCategory == null)
            {
                return NotFound();
            }
            return View(projectCategory);
        }

        // POST: ProjectCategories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Description,ImagePath")] ProjectCategory projectCategory)
        {
            if (id != projectCategory.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(projectCategory);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProjectCategoryExists(projectCategory.Id))
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
            return View(projectCategory);
        }

        // GET: ProjectCategories/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var projectCategory = await _context.ProjectCategories
                .FirstOrDefaultAsync(m => m.Id == id);
            if (projectCategory == null)
            {
                return NotFound();
            }

            return View(projectCategory);
        }

        // POST: ProjectCategories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var projectCategory = await _context.ProjectCategories.FindAsync(id);
            if (projectCategory != null)
            {
                _context.ProjectCategories.Remove(projectCategory);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProjectCategoryExists(int id)
        {
            return _context.ProjectCategories.Any(e => e.Id == id);
        }
    }
}
