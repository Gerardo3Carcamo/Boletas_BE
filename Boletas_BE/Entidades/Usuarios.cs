using System.ComponentModel.DataAnnotations.Schema;

namespace Boletas_BE.Entidades
{
    [Table("usuarios")]
    public class Usuarios
    {
        public int Id { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string? Usuario { get; set; }
        public string? Password { get; set; }
        public int Rol { get; set; }
    }
}
