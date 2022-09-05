using System.ComponentModel.DataAnnotations;
namespace Tarea1.Models
{
    public class Ocupaciones
    {
        [Key]
        public int OcupacionId { get; set; }
        [Required(ErrorMessage ="La descripcion es requerida")]
        public string? Descripcion { get; set; }
        public float? Salario { get; set; }

    }
}
