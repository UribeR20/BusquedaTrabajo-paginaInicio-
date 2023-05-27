using Microsoft.AspNetCore.Mvc;

namespace BusquedaTrabajo_paginaInicio_.Controllers
{
    public class InicioSesionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
