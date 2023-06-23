using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppEntityCore.Models
{
    [Index(nameof(Codigo), IsUnique = true)]
    [Table("Productos")]
    public class Producto
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string? Nombre { get; set; }
        [Column("Descripcion_Producto")]
        public string? Descripcion { get; set; }
        [ForeignKey("Categoria")]
        public int CategoriaId { get; set; }
        public Categoria? Categoria { get; set; }
        [Range(0, 100)]
        public int Stock { get; set; }

        public int Codigo { get; set; }
    }
}
