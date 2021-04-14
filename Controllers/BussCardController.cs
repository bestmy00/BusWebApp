using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SchoolBussWebApp.Data;
using SchoolBussWebApp.Models;

namespace SchoolBussWebApp.Controllers
{
    public class BussCardController : Controller
    {
        private readonly BussDbContext _context;

        public BussCardController(BussDbContext context)
        {
            _context = context;
        }

        // GET: BussCard
        public async Task<IActionResult> Index(string selectBusLine)
        {
            IQueryable<string> busLineQuery = from m in _context.BussCard
                orderby m.Buss_Line
                select m.Buss_Line;

            string query = "Select * from BussCard ";

            if (!string.IsNullOrEmpty(selectBusLine))
            {
                query = query + "where buss_line = '" + selectBusLine + "' ";
            }

            query = query + "order by Issu_Numb ";

            var cards = _context.BussCard
                .FromSqlRaw(query);
                


            var cardListVM = new CardListViewModel
            {
                SelectBusLine = new SelectList(await busLineQuery.Distinct().ToListAsync()),
                Cards = await cards.ToListAsync()
            };

            return View(cardListVM);
        }

        // GET: BussCard/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bussCard = await _context.BussCard
                .FirstOrDefaultAsync(m => m.Card_Uuid == id);
            if (bussCard == null)
            {
                return NotFound();
            }

            return View(bussCard);
        }

        // GET: BussCard/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: BussCard/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Seq,Buss_Code,Buss_Line,Issu_Numb,Card_Uuid,Card_Prob,Card_Stat")] BussCard bussCard)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bussCard);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(bussCard);
        }

        // GET: BussCard/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bussCard = await _context.BussCard.FindAsync(id);
            if (bussCard == null)
            {
                return NotFound();
            }
            return View(bussCard);
        }

        // POST: BussCard/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Seq,Buss_Code,Buss_Line,Issu_Numb,Card_Uuid,Card_Prob,Card_Stat")] BussCard bussCard)
        {
            if (id != bussCard.Card_Uuid)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bussCard);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BussCardExists(bussCard.Card_Uuid))
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
            return View(bussCard);
        }

        // GET: BussCard/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bussCard = await _context.BussCard
                .FirstOrDefaultAsync(m => m.Card_Uuid == id);
            if (bussCard == null)
            {
                return NotFound();
            }

            return View(bussCard);
        }

        // POST: BussCard/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var bussCard = await _context.BussCard.FindAsync(id);
            _context.BussCard.Remove(bussCard);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BussCardExists(string id)
        {
            return _context.BussCard.Any(e => e.Card_Uuid == id);
        }
    }
}
