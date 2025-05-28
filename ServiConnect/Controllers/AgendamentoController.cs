using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ServiConnect.Models;

namespace ServiConnect.Controllers
{
    public class AgendamentoController : Controller
    {
        private readonly AppDbContext _context;

        public AgendamentoController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<ActionResult> Index()
        {
            var dados = await _context.agendamento.ToListAsync();

            return View(dados);
        }
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Agendamento agendamento)
        {
            if (ModelState.IsValid)
            {
                _context.Add(agendamento);
                _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }


            return View(agendamento);
        }
        public async Task<IActionResult> Detais(int? id)
        {
            if (id == null)
                return NotFound();

            var dados = await _context.agendamento.FindAsync(id);

            if (dados == null)
                return NotFound();

            return View(dados);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
                return NotFound();

            var dados = await _context.agendamento.FindAsync(id);

            if (dados == null)
                return NotFound();

            return View(dados);
        }

        [HttpPost, ActionName("Delete")]

        public async Task<IActionResult> DeleteConfirmad(int? id)
        {
            if (id == null)
                return NotFound();

            var dados = await _context.agendamento.FindAsync(id);

            if (dados == null)
                return NotFound();

            _context.agendamento.Remove(dados);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");

        }
    }
}
