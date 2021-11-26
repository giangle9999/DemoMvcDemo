using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Demo.Data;
using Demo.Models;

namespace Demo.Controllers
{
    public class Demo123Controller : Controller
    {
        private readonly DemoDBContext _context;

        public Demo123Controller(DemoDBContext context)
        {
            _context = context;
        }

        // GET: Demo123
        public async Task<IActionResult> Index()
        {
            return View(await _context.Demo123.ToListAsync());
        }

        // GET: Demo123/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var demo123 = await _context.Demo123
                .FirstOrDefaultAsync(m => m.Demo123ID == id);
            if (demo123 == null)
            {
                return NotFound();
            }

            return View(demo123);
        }

        // GET: Demo123/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Demo123/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Demo123ID,Demo123Name")] Demo123 demo123)
        {
            try{
                if (ModelState.IsValid)
            {
                _context.Add(demo123);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            }
            catch{
                ModelState.AddModelError("","Khoa chinh bi trung");
            }
            if (ModelState.IsValid)
            {
                _context.Add(demo123);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(demo123);
        }

        // GET: Demo123/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var demo123 = await _context.Demo123.FindAsync(id);
            if (demo123 == null)
            {
                return NotFound();
            }
            return View(demo123);
        }

        // POST: Demo123/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Demo123ID,Demo123Name")] Demo123 demo123)
        {
            if (id != demo123.Demo123ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(demo123);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Demo123Exists(demo123.Demo123ID))
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
            return View(demo123);
        }

        // GET: Demo123/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var demo123 = await _context.Demo123
                .FirstOrDefaultAsync(m => m.Demo123ID == id);
            if (demo123 == null)
            {
                return NotFound();
            }

            return View(demo123);
        }

        // POST: Demo123/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var demo123 = await _context.Demo123.FindAsync(id);
            _context.Demo123.Remove(demo123);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Demo123Exists(string id)
        {
            return _context.Demo123.Any(e => e.Demo123ID == id);
        }
    }
}
