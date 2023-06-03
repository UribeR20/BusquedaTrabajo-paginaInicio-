using System.ComponentModel.DataAnnotations;
namespace BusquedaTrabajo_paginaInicio_.Models
{
    public class login
    {
        [Key]
        public int id_login { get; set; }
        public string nombre { get; set; }
        public string correo { get; set; }
        public string contraseña { get; set; }
        public string nombreUusario { get; set; }

    }
}
