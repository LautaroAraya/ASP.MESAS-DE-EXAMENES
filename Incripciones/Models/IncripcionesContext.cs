using Incripciones.Models;
using Microsoft.EntityFrameworkCore;

namespace Inscripcioness.Models
{
    public class InscripcionesContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;
                           Database=InscripcionesContext;
                           User Id = sa; Password = 123;
                           Encrypt=false");
        }
       public virtual DbSet<Alumno> Alumnos { get; set; }
    }
}
