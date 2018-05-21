using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MyShop.Models;
using MyShop.ViewModels;

namespace MyShop.Controllers
{
    public class SnowboardsController : Controller
    {
        private readonly AppDbContext _context;

        public SnowboardsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Snowboards
        public async Task<IActionResult> Index(string id)
        {

            var snowboards = from s in _context.Snowboards.OrderBy(s => s.Brand) select s;

            if(!String.IsNullOrEmpty(id))
            {
                snowboards = snowboards.Where(s => s.Brand.Contains(id));
            }

            var snowboardsViewModel = new SnowboardsViewModel()
            {
                Snowboards = await snowboards.ToListAsync(),
                Title = "Our snowboards"
            };
            return View(snowboardsViewModel);
        }

        // GET: Snowboards/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var snowboard = await _context.Snowboards
                .SingleOrDefaultAsync(m => m.Id == id);
            if (snowboard == null)
            {
                return NotFound();
            }

            return View(snowboard);
        }
        [Authorize(Roles = "Administrators")]
        // GET: Snowboards/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Snowboards/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize(Roles = "Administrators")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Brand,Model,Price,Length,LongDescription,RidingStyle,ImageThumbnailUrl")] Snowboard snowboard)
        {
            if (ModelState.IsValid)
            {
                _context.Add(snowboard);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(snowboard);
        }
        [Authorize(Roles = "Administrators")]
        // GET: Snowboards/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var snowboard = await _context.Snowboards.SingleOrDefaultAsync(m => m.Id == id);
            if (snowboard == null)
            {
                return NotFound();
            }
            return View(snowboard);
        }

        // POST: Snowboards/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize(Roles = "Administrators")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Brand,Model,Price,Length,LongDescription,RidingStyle,ImageThumbnailUrl")] Snowboard snowboard)
        {
            if (id != snowboard.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(snowboard);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SnowboardExists(snowboard.Id))
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
            return View(snowboard);
        }

        // GET: Snowboards/Delete/5
        [Authorize(Roles = "Administrators")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var snowboard = await _context.Snowboards
                .SingleOrDefaultAsync(m => m.Id == id);
            if (snowboard == null)
            {
                return NotFound();
            }

            return View(snowboard);
        }

        // POST: Snowboards/Delete/5
        [Authorize(Roles = "Administrators")]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var snowboard = await _context.Snowboards.SingleOrDefaultAsync(m => m.Id == id);
            _context.Snowboards.Remove(snowboard);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SnowboardExists(int id)
        {
            return _context.Snowboards.Any(e => e.Id == id);
        }
    }
}
