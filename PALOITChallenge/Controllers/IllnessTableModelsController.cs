using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PALOITChallenge.Models;
namespace PALOITChallenge.Controllers
{
    public class Diseases : Controller
    {
        private readonly ZombiesData _context;

        public Diseases(ZombiesData context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Diseasses.ToListAsync());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IllnessId,painLevel,Name,Id")] IllnessTableModel illnessTableModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(illnessTableModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(illnessTableModel);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var illnessTableModel = await _context.Diseasses.FindAsync(id);
            if (illnessTableModel == null)
            {
                return NotFound();
            }
            return View(illnessTableModel);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("IllnessId,painLevel,Name,Id")] IllnessTableModel illnessTableModel)
        {
            if (id != illnessTableModel.IllnessId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(illnessTableModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!IllnessTableModelExists(illnessTableModel.IllnessId))
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
            return View(illnessTableModel);
        }



        private bool IllnessTableModelExists(int id)
        {
            return _context.Diseasses.Any(e => e.IllnessId == id);
        }
    }
}
