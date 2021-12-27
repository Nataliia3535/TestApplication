using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestApplication.DATA;
using TestApplication.Models;

namespace TestApplication.Controllers
{
    public class IncidentController : Controller
    {
        private readonly IncidentContext _context;

        public IncidentController(IncidentContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var incidents = _context.Incidents.ToList();
            return View(incidents);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Incident incident)
        {
            if (ModelState.IsValid)
            {
                _context.Incidents.Add(incident);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(incident);
        }
        public IActionResult Edit(int? id)
        {
            if (id == null || id <= 0)
                return BadRequest();
            var incidentDb = _context.Incidents.FirstOrDefault(e => e.Id == id);
            if (incidentDb == null)
                return NotFound();
            return View(incidentDb);
        }
        [HttpPost]
        public IActionResult Edit(Incident incident)
        {
            if (!ModelState.IsValid)
                return View(incident);
            _context.Incidents.Update(incident);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));

        }

        public IActionResult Delete(int? id)
        {
            if (id == null || id <= 0)
                return BadRequest();
            var incidentDb = _context.Incidents.FirstOrDefault(e => e.Id == id);
            if (incidentDb == null)
                return NotFound();
            _context.Incidents.Remove(incidentDb);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
