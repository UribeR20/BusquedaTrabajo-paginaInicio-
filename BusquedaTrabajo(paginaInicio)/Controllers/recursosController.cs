using Microsoft.AspNetCore.Mvc;

namespace BusquedaTrabajo_paginaInicio_.Controllers
{
    public class recursosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
