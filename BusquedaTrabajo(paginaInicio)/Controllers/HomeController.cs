using BusquedaTrabajo_paginaInicio_.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BusquedaTrabajo_paginaInicio_.Controllers
{
    public class HomeController : Controller
    {


        private readonly portalTrabajoContexto _portalTrabajoContexto;
        public HomeController(portalTrabajoContexto portalTrabajoContexto)
        {
            _portalTrabajoContexto = portalTrabajoContexto;
        }

        public IActionResult Index()
        {
            listas();
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        

        public void listas()
        {
            var listadoDeMarcas = (from r in _portalTrabajoContexto.empleos
                                 select new
                                 {
                                     imagen = r.imagen                                     
                                 }).ToList();

            ViewData["listadoDeMarcas"] = listadoDeMarcas;
        }
    }
}