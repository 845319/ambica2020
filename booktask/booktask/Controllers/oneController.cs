using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using booktask.Models;
using booktask.datalayer;

namespace booktask.Controllers
{
    public class oneController : Controller
    {
        private readonly bookcontext _context;

        public oneController(bookcontext context)
        {
            _context = context;
        }

        // GET: one
        public async Task<IActionResult> Index(string Bookcategory, string searcher,string publishercategory)
        {
            IQueryable<string> categoryquery = from b in _context.ones orderby b.Category select b.Category;
            
            var Ones = from b in _context.ones select b;
            IQueryable<string> publisherquery = from s in _context.ones orderby s.Publisher select s.Publisher;

            if (!string.IsNullOrEmpty(publishercategory))
            {
                Ones = Ones.Where(s => s.Publisher.Contains(publishercategory));
            }
            if(!string.IsNullOrEmpty(searcher))
            {
                Ones = Ones.Where(b => b.Btitle.Contains(searcher));
            }
            if(!string.IsNullOrEmpty(Bookcategory))
            {
                Ones = Ones.Where(b => b.Category == Bookcategory);
            }
            var bookcategoryVM = new bookcategoryviewmodel
            {
                Categories = new SelectList(await categoryquery.Distinct().ToListAsync()),
                ones = await Ones.ToListAsync(),
                publishers = new SelectList(await publisherquery.Distinct().ToListAsync())
                
            };
            return View(bookcategoryVM);
           // return View(await _context.ones.ToListAsync());
        }

        // GET: one/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var one = await _context.ones
                .FirstOrDefaultAsync(m => m.Bid == id);
            if (one == null)
            {
                return NotFound();
            }

            return View(one);
        }

        // GET: one/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: one/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Bid,Btitle,Category,Price,AuthorName,Publisher,Releasedate")] one one)
        {
            if (ModelState.IsValid)
            {
                _context.Add(one);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(one);
        }

        // GET: one/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var one = await _context.ones.FindAsync(id);
            if (one == null)
            {
                return NotFound();
            }
            return View(one);
        }

        // POST: one/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Bid,Btitle,Category,Price,AuthorName,Publisher,Releasedate")] one one)
        {
            if (id != one.Bid)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(one);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!oneExists(one.Bid))
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
            return View(one);
        }

        // GET: one/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var one = await _context.ones
                .FirstOrDefaultAsync(m => m.Bid == id);
            if (one == null)
            {
                return NotFound();
            }

            return View(one);
        }

        // POST: one/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var one = await _context.ones.FindAsync(id);
            _context.ones.Remove(one);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool oneExists(int id)
        {
            return _context.ones.Any(e => e.Bid == id);
        }
    }
}
