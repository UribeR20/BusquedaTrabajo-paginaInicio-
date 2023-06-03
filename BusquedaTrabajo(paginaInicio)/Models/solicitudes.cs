using System.ComponentModel.DataAnnotations;
namespace BusquedaTrabajo_paginaInicio_.Models
{
    public class solicitudes
    {
        [Key]
        public int id_solicitud { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int edad { get; set; }
        public string nivel_academico { get; set; }
        public string especialidad { get; set; }
        public string curriculum { get; set; }
    }
}
