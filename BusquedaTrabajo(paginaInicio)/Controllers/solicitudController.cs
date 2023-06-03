using BusquedaTrabajo_paginaInicio_.Models;
using Microsoft.AspNetCore.Mvc;

namespace BusquedaTrabajo_paginaInicio_.Controllers
{
    public class solicitudController : Controller
    {
        private readonly portalTrabajoContexto _portalTrabajoContexto;
        public solicitudController(portalTrabajoContexto portalTrabajoContexto)
        {
            _portalTrabajoContexto = portalTrabajoContexto;
        }
        public IActionResult Index()
        {              
            return View();
        }

        public IActionResult crearSolicitud(solicitudes nuevaSolicitud)
        {
            _portalTrabajoContexto.Add(nuevaSolicitud);
            _portalTrabajoContexto.SaveChanges();

            return RedirectToAction("Index");
        }



    }
}
