﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BazaPoklona.Models;

namespace BazaPoklona.Controllers
{
    class Pet
    {
        public string Name { get; set; }
        public double Age { get; set; }
    }

    public class VrstaRobesController : Controller
    {
        private readonly BazaPoklonaContext _context;

        public VrstaRobesController(BazaPoklonaContext context)
        {
            _context = context;
        }

        // GET: VrstaRobes
        public async Task<IActionResult> Index()
        {
            return View(await _context.VrstaRobes.ToListAsync());
        }

        // GET: VrstaRobes
        public async Task<IActionResult> OstvareniPromet()
        {            
            var dbPoklons = await _context.Poklons.ToListAsync();

            var results = from p in dbPoklons
                          orderby p.VrstaRobe
                          group p by p.VrstaRobe
                          into newData
                          select new Poklon
                          {
                              VrstaRobe = newData.Key,
                              Naziv = newData.Max(d => d.Naziv),
                              Cijena = newData.Sum(x => x.Cijena)
                          };

            return View(results);            

        }

        // GET: VrstaRobes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vrstaRobe = await _context.VrstaRobes
                .Include(p => p.Poklons)
                .Include(t => t.Trgovinas)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (vrstaRobe == null)
            {
                return NotFound();
            }

            return View(vrstaRobe);
        }

        // GET: VrstaRobes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: VrstaRobes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Naziv")] VrstaRobe vrstaRobe)
        {
            if (ModelState.IsValid)
            {
                _context.Add(vrstaRobe);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(vrstaRobe);
        }

        // GET: VrstaRobes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vrstaRobe = await _context.VrstaRobes.FindAsync(id);
            if (vrstaRobe == null)
            {
                return NotFound();
            }
            return View(vrstaRobe);
        }

        // POST: VrstaRobes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Naziv")] VrstaRobe vrstaRobe)
        {
            if (id != vrstaRobe.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(vrstaRobe);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VrstaRobeExists(vrstaRobe.Id))
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
            return View(vrstaRobe);
        }

        // GET: VrstaRobes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vrstaRobe = await _context.VrstaRobes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (vrstaRobe == null)
            {
                return NotFound();
            }

            return View(vrstaRobe);
        }

        // POST: VrstaRobes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var vrstaRobe = await _context.VrstaRobes.FindAsync(id);
            _context.VrstaRobes.Remove(vrstaRobe);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VrstaRobeExists(int id)
        {
            return _context.VrstaRobes.Any(e => e.Id == id);
        }
    }
}
