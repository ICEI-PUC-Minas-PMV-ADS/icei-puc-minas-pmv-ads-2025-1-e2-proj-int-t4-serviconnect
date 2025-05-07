using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ServiConnect.Models;

namespace ServiConnect.Controllers
{
    public class PrestadorControler : Controller
    {
        public readonly  AppDbContext _context;
        public PrestadorControler(AppDbContext context)
        {
            _context = context; 
        }

        public async Task<IActionResult> Index ()
        {
            var dados = await _context.User.ToListAsync();     

            return View (dados);

        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(User user)
        {
            if (ModelState.IsValid)
            {
                _context.Add(user);
                await _context.SaveChangesAsync();  
                return RedirectToAction("Index");
            }
            return View(user);
        }

    }
}
