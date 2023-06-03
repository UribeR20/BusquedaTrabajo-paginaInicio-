using System.ComponentModel.DataAnnotations;
namespace BusquedaTrabajo_paginaInicio_.Models
{
    public class empleos
    {
        [Key]
        public int id_empresa { get; set; }
        public string nombreEmpresa { get; set; }
        public string descripcion { get; set; }
        public string cargo { get; set; }
        public string imagen { get; set; }
        public string? requisitos { get; set; }
    }
}
