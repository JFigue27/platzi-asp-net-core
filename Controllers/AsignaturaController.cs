using System;
using Microsoft.AspNetCore.Mvc;
using platzi_asp_net_core.Models;

namespace platzi_asp_net_core.Controllers
{
    public class AsignaturaController : Controller
    {
        public IActionResult Index()
        {
            var asignatura = new Asignatura{
                UniqueId = Guid.NewGuid().ToString(),
                Nombre = "Programación"
            };

            ViewBag.CosaDinamica = "Iron-Man";
            ViewBag.Fecha = DateTime.Now;
            
            
            return View(asignatura);
        }
    }
}