using Microsoft.AspNetCore.Mvc;

namespace BusquedaTrabajo_paginaInicio_.Controllers
{
    public class perfilController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
