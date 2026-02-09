using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Boletas_BE.Entidades
{
    [Table("roles")]
    public class Roles
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
    }
}
