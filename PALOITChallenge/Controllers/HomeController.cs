using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using haljson;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using PALOITChallenge.Models;
using PALOITChallenge.ViewModels;

namespace PALOITChallenge.Controllers
{
   
    public class HomeController : Controller
    {
        private IConfiguration _configuration;
        private string _hospitalsEndpoint ;
        private string _illnessEndpoint;
 

        private readonly ZombiesData _context;


        public  HomeController(IConfiguration Configuration, ZombiesData context)
        {
            _configuration = Configuration;
            _hospitalsEndpoint = _configuration["Hospitals"];
            _illnessEndpoint = _configuration["Illnesses"];
            _context = context;


        }
     
        public async Task<IActionResult> Index(HospitalViewModel model)
        {
            await Services.PopulateIllness(_context, _illnessEndpoint);
            if (model.Illnesspain >0) model.Level = (PainLevels)model.Illnesspain;
            model.hospitals = Services.GetHospitals(_hospitalsEndpoint,model.Level).Result.hospitals.ToList();
            model.hospitals = Services.SortBy(model.hospitals, p => p.waitingTime);
            ViewBag.illness = new SelectList(Services.GetIllness(_context), "painLevel", "Name")  ;
            
            return View(model);
        }
        public ActionResult Contact()
        {
            
            return View();
        }
        private async  Task PopulateIllness()
        {
           var  Diseases = await Services.GetData<Illnesses>(_illnessEndpoint);

            if (!_context.Diseasses.Any())
            {  foreach (IllnessElement i in Diseases._illnesses)
               {
                    _context.Diseasses.Add(new IllnessTableModel() { IllnessId = i.Illness.IllnessId , Name = i.Illness.Name, painLevel = 0 });

               }
                _context.SaveChanges();
            }
        }
    }
}
