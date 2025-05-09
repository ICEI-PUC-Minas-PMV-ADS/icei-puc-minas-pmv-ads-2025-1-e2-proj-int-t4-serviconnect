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
            var dados = await _context.Prestador.ToListAsync();

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
    }
}
