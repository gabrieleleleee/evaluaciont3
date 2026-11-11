using EVALUACION_T3.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EVALUACION_T3.Models;

namespace EVALUACION_T3.Controllers
{
    public class AventureroController : Controller
    {
        private readonly GuildaDbContext _context;

        public AventureroController(GuildaDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        //mostrar index de aventureros

        public async Task<IActionResult> ListarAventureros()
        {
            var aventureros = await _context.Aventureros.ToListAsync();
            return View(aventureros);
        }

        public async Task<IActionResult> DetallesAventurero(int id)
        {
            var aventurero = await _context.Aventureros.FindAsync(id);
            if (aventurero == null)
            {
                return NotFound();
            }
            return View(aventurero);
        }

        [HttpPost]
        public async Task<IActionResult> CrearAventurero(Aventurero aventurero)
        {
            if (ModelState.IsValid)
            {
                _context.Add(aventurero);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(ListarAventureros));
            }
            return View(aventurero);
        }









    }
}
