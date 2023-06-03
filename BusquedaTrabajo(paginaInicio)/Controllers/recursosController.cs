using Microsoft.AspNetCore.Mvc;

namespace BusquedaTrabajo_paginaInicio_.Controllers
{
    public class recursosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult articulos()
        {
            return View();
        }

        public IActionResult videos()
        {
            return View();
        }
    }
}
