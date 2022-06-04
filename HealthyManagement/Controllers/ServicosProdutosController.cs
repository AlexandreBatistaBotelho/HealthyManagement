using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HealthyManagement.Data;
using HealthyManagement.Models;

namespace HealthyManagement.Controllers
{
    public class ServicosProdutosController : Controller
    {
        private readonly HealthyManagementContext _context;

        public ServicosProdutosController(HealthyManagementContext context)
        {
            _context = context;
        }

        // GET: ServicosProdutos
        public async Task<IActionResult> Index()
        {
            return View(await _context.ServicoProduto.ToListAsync());
        }

        // GET: ServicosProdutos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var servicoProduto = await _context.ServicoProduto
                .FirstOrDefaultAsync(m => m.Id == id);
            if (servicoProduto == null)
            {
                return NotFound();
            }

            return View(servicoProduto);
        }

        // GET: ServicosProdutos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ServicosProdutos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome,Descricao,Preco,TipoVenda")] ServicoProduto servicoProduto)
        {
            if (ModelState.IsValid)
            {
                _context.Add(servicoProduto);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(servicoProduto);
        }

        // GET: ServicosProdutos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var servicoProduto = await _context.ServicoProduto.FindAsync(id);
            if (servicoProduto == null)
            {
                return NotFound();
            }
            return View(servicoProduto);
        }

        // POST: ServicosProdutos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,Descricao,Preco,TipoVenda")] ServicoProduto servicoProduto)
        {
            if (id != servicoProduto.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(servicoProduto);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ServicoProdutoExists(servicoProduto.Id))
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
            return View(servicoProduto);
        }

        // GET: ServicosProdutos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var servicoProduto = await _context.ServicoProduto
                .FirstOrDefaultAsync(m => m.Id == id);
            if (servicoProduto == null)
            {
                return NotFound();
            }

            return View(servicoProduto);
        }

        // POST: ServicosProdutos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var servicoProduto = await _context.ServicoProduto.FindAsync(id);
            _context.ServicoProduto.Remove(servicoProduto);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ServicoProdutoExists(int id)
        {
            return _context.ServicoProduto.Any(e => e.Id == id);
        }
    }
}
