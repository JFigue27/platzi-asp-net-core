using System;
using Microsoft.AspNetCore.Mvc;
using platzi_asp_net_core.Models;

namespace platzi_asp_net_core.Controllers
{
    public class EscuelaController : Controller
    {
        public IActionResult Index()
        {
            var escuela = new Escuela();
            escuela.AñoDeCreación = 2005;
            escuela.UniqueId = Guid.NewGuid().ToString();
            escuela.Nombre = "Platzi School";
            escuela.Dirección = "Quinta Mayorga";
            escuela.Ciudad = "Juárez Chihuahua";
            escuela.Pais = "México";
            ViewBag.CosaDinamica = "MowGli";
            
            return View(escuela);
        }
    }
}