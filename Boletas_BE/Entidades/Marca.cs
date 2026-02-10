using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Boletas_BE.Entidades
{
    [Table("marcas")]
    public class Marca
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Imagen { get; set; }
    }
}
