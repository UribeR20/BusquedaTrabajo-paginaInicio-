using Microsoft.AspNetCore.Mvc;

namespace BusquedaTrabajo_paginaInicio_.Controllers
{
    public class detallesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
