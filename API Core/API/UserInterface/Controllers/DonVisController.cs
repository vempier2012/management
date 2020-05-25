using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using UserInterface.Models;

namespace UserInterface.Controllers
{
    public class DonVisController : Controller
    {
        private readonly TestDatabaseContext _context;

        public DonVisController(TestDatabaseContext context)
        {
            _context = context;
        }

        // GET: DonVis
        public async Task<IActionResult> Index()
        {
            return View(await _context.DonVi.ToListAsync());
        }

        // GET: DonVis/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var donVi = await _context.DonVi
                .FirstOrDefaultAsync(m => m.Madonvi == id);
            if (donVi == null)
            {
                return NotFound();
            }

            return View(donVi);
        }

        // GET: DonVis/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: DonVis/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Madonvi,Tendonvi,Email,Nguoitao,Ngaytao,Nguoicapnhat,Ngaycapnhat,Solancapnhat,Trangthai")] DonVi donVi)
        {
            if (ModelState.IsValid)
            {
                _context.Add(donVi);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(donVi);
        }

        // GET: DonVis/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var donVi = await _context.DonVi.FindAsync(id);
            if (donVi == null)
            {
                return NotFound();
            }
            return View(donVi);
        }

        // POST: DonVis/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Madonvi,Tendonvi,Email,Nguoitao,Ngaytao,Nguoicapnhat,Ngaycapnhat,Solancapnhat,Trangthai")] DonVi donVi)
        {
            if (id != donVi.Madonvi)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(donVi);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DonViExists(donVi.Madonvi))
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
            return View(donVi);
        }

        // GET: DonVis/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var donVi = await _context.DonVi
                .FirstOrDefaultAsync(m => m.Madonvi == id);
            if (donVi == null)
            {
                return NotFound();
            }

            return View(donVi);
        }

        // POST: DonVis/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var donVi = await _context.DonVi.FindAsync(id);
            _context.DonVi.Remove(donVi);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DonViExists(string id)
        {
            return _context.DonVi.Any(e => e.Madonvi == id);
        }
    }
}
