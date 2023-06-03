using Microsoft.EntityFrameworkCore;
namespace BusquedaTrabajo_paginaInicio_.Models
{
    public class portalTrabajoContexto : DbContext
    {
        public portalTrabajoContexto(DbContextOptions options) : base(options)
        {
        }

        public DbSet<solicitudes> solicitudes { get; set;}
        public DbSet<empleos> empleos { get; set;}
        public DbSet<login> login { get; set;}
    }
}
