using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using PALOITChallenge;
using PALOITChallenge.Models;

namespace PALOITChallenge.Controllers
{
    public class PatientsController : Controller
    {
        private readonly ZombiesData _context;
        
        private readonly IConfiguration _configuration;
        private  List<Hospital> _hospitalsLst=new List<Hospital>();

        public PatientsController(ZombiesData context,IConfiguration configuration)
        {
            _configuration = configuration;
            _context = context;
            _hospitalsLst = Services.GetHospitals(_configuration["Hospitals"],null).Result.hospitals;


        }

        // GET: Patients
        public async Task<IActionResult> Index()
        {
            ViewBag.Illness = Services.GetIllness(_context);
            return View(await _context.Patients.ToListAsync());
        }
 
        public async Task<IActionResult> Create()
        {
            ViewBag.illness = new SelectList(Services.GetIllness(_context), "IllnessId", "Name");
            ViewBag.hospitals =  new SelectList(_hospitalsLst,"name","name");
            return View();
        }
   
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,IllnessId,HospitalName")] Patient patient)
        {
            if (ModelState.IsValid)
            {
                _context.Add(patient);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
           
            return View(patient);
        }
    }
}
