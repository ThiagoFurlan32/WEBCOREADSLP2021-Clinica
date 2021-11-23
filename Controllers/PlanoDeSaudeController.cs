using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WEBCORELP2021.Models;
using WEBCORELP2021.Models.Dominio;

namespace WEBCORELP2021.Controllers
{
    public class PlanoDeSaudeController : Controller
    {
        private readonly Contexto _context;

        public PlanoDeSaudeController(Contexto context)
        {
            _context = context;
        }

        // GET: PlanoDeSaude
        public async Task<IActionResult> Index()
        {
            var contexto = _context.PlanosDeSaude.Include(p => p.paciente);
            return View(await contexto.ToListAsync());
        }

        // GET: PlanoDeSaude/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var planoDeSaude = await _context.PlanosDeSaude
                .Include(p => p.paciente)
                .FirstOrDefaultAsync(m => m.id == id);
            if (planoDeSaude == null)
            {
                return NotFound();
            }

            return View(planoDeSaude);
        }

        // GET: PlanoDeSaude/Create
        public IActionResult Create()
        {
            ViewData["pacienteID"] = new SelectList(_context.Pacientes, "id", "cidade");
            return View();
        }

        // POST: PlanoDeSaude/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,nome,descricao,pacienteID")] PlanoDeSaude planoDeSaude)
        {
            if (ModelState.IsValid)
            {
                _context.Add(planoDeSaude);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["pacienteID"] = new SelectList(_context.Pacientes, "id", "cidade", planoDeSaude.pacienteID);
            return View(planoDeSaude);
        }

        // GET: PlanoDeSaude/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var planoDeSaude = await _context.PlanosDeSaude.FindAsync(id);
            if (planoDeSaude == null)
            {
                return NotFound();
            }
            ViewData["pacienteID"] = new SelectList(_context.Pacientes, "id", "cidade", planoDeSaude.pacienteID);
            return View(planoDeSaude);
        }

        // POST: PlanoDeSaude/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,nome,descricao,pacienteID")] PlanoDeSaude planoDeSaude)
        {
            if (id != planoDeSaude.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(planoDeSaude);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PlanoDeSaudeExists(planoDeSaude.id))
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
            ViewData["pacienteID"] = new SelectList(_context.Pacientes, "id", "cidade", planoDeSaude.pacienteID);
            return View(planoDeSaude);
        }

        // GET: PlanoDeSaude/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var planoDeSaude = await _context.PlanosDeSaude
                .Include(p => p.paciente)
                .FirstOrDefaultAsync(m => m.id == id);
            if (planoDeSaude == null)
            {
                return NotFound();
            }

            return View(planoDeSaude);
        }

        // POST: PlanoDeSaude/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var planoDeSaude = await _context.PlanosDeSaude.FindAsync(id);
            _context.PlanosDeSaude.Remove(planoDeSaude);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PlanoDeSaudeExists(int id)
        {
            return _context.PlanosDeSaude.Any(e => e.id == id);
        }
    }
}
