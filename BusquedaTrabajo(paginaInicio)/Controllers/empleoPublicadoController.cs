using BusquedaTrabajo_paginaInicio_.Models;
using Microsoft.AspNetCore.Mvc;

namespace BusquedaTrabajo_paginaInicio_.Controllers
{

    public class empleoPublicadoController : Controller
    {
        private readonly portalTrabajoContexto _portalTrabajoContexto;
        public empleoPublicadoController(portalTrabajoContexto portalTrabajoContexto)
        {
            _portalTrabajoContexto = portalTrabajoContexto;
        }
        public IActionResult Index()
        {
            listadoEmpresas();
            return View();
        }

        public void listadoEmpresas()
        {
            var listaEmpleos = (from e in _portalTrabajoContexto.empleos 
                                select new
            {
                nombre = e.nombreEmpresa,
                descripcion = e.descripcion,
                cargo= e.cargo,
                imagen = e.imagen,
                requisitos = e.requisitos
                                }).ToList();

            ViewData["listaEmpleos"] = listaEmpleos;
        }
    }
}
