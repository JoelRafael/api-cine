using System.ComponentModel.DataAnnotations;

namespace ApiCine.Models
{
    public partial class Actor
    {
        public Actor()
        {
            this.Peliculas = new HashSet<Pelicula>();
        }
        [Key]
        public int? ActorId { get; set; }
        public string NombreCompleto { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Sexo { get; set; }
        public byte[]? Foto { get; set; }
        public string Detalles { get; set; }
        public  ICollection<Pelicula>?Peliculas { get; set; }
    }
}
