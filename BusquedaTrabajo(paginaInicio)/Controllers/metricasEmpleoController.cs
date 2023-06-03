using BusquedaTrabajo_paginaInicio_.Models;
using Microsoft.AspNetCore.Mvc;

namespace BusquedaTrabajo_paginaInicio_.Controllers
{
    public class metricasEmpleoController : Controller
    {
        private readonly portalTrabajoContexto _portalTrabajoContexto;
        public metricasEmpleoController(portalTrabajoContexto portalTrabajoContexto)
        {
            _portalTrabajoContexto = portalTrabajoContexto;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult crearEmpresa(empleos nuevaEmpresa)
        {
            _portalTrabajoContexto.Add(nuevaEmpresa);
            _portalTrabajoContexto.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
