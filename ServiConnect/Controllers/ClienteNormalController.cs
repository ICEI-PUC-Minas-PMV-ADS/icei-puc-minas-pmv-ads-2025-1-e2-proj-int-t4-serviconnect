using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ServiConnect.Models;

namespace ServiConnect.Controllers
{
    public class ClienteNormal : Controller
    {
        private readonly AppDbContext _context;

        public ClienteNormal(AppDbContext context)
        {
            _context = context;
        }

        public async Task<ActionResult> Index()
        {
            var dados = await _context.prestador.ToListAsync();

            return View(dados);
        }

     
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
                return NotFound();

            var dados = await _context.prestador.FindAsync(id);

            if (dados == null)
                return NotFound();

            return View(dados);
        }

        

        

        


    }
}


