using System.ComponentModel.DataAnnotations;
namespace ApiCine.Models
{
    public partial class Pelicula
        
    {
        [Key]
        public int? PeliculaId { get; set; }
        public int ActorId { get; set; }
        public string Titulo { get; set; }
        public string Genero { get; set; }
        public DateTime FechaDeEstreno { get; set; }
        public Actor? Actors { get; set; }
    }

    
}
