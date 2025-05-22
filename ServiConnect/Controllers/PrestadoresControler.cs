using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ServiConnect.Models;

namespace ServiConnect.Controllers
{
    public class PrestadoresControler : Controller
    {
        private readonly AppDbContext _context;
       
        public PrestadoresControler(AppDbContext context)
        {
            _context = context;
        }

        public async Task<ActionResult> Index()
        {
            var dados = await _context.prestador.ToListAsync();

            return View(dados);
        }

        public ActionResult Create()
        {
            return View();      
        }

        [HttpPost]
        public ActionResult Create(Prestador prestador)
        {
            if (ModelState.IsValid)
            {
                _context.Add(prestador);
                _context.SaveChangesAsync();
                return RedirectToAction("Index");   
            }
            
     
            return View(prestador);
        }
       public async Task<IActionResult> Edit(int? id)
        {
            if(id == null)
                return NotFound();  

            var dados = await _context.prestador.FindAsync(id);

            if (dados == null)
                return NotFound();
          
            return View(dados);  
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int Id, Prestador prestador)
        {
            if(Id != prestador.Id)
                return NotFound();

            if (ModelState.IsValid)
            {
                _context.prestador.Update(prestador);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
   
            return View();
        }


        public async Task<IActionResult> Detais(int? id)
        {
            if (id == null)
                return NotFound();

            var dados = await _context.prestador.FindAsync(id);

            if (dados == null)
                return NotFound();

            return View(dados);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
                return NotFound();

            var dados = await _context.prestador.FindAsync(id);

            if (dados == null)
                return NotFound();

            return View(dados);
        }

        [HttpPost, ActionName("Delete")]

        public async Task<IActionResult> DeleteConfirmad (int? id)
        {
            if (id == null)
                return NotFound();

            var dados = await _context.prestador.FindAsync(id);

            if (dados == null)
                return NotFound();

            _context.prestador.Remove(dados);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");

        }


    }
}
