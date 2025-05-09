using Microsoft.EntityFrameworkCore;
using ApiCine.Models;
namespace ApiCine.Models
{
    public class appcontext : DbContext
    {
        public appcontext(DbContextOptions<appcontext>options):base(options)
        {
          
        }
        public DbSet<Actor> Actores { get; set; }
        public DbSet<Pelicula> Peliculas { get; set; }
    }
}
