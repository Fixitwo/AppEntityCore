using System.ComponentModel.DataAnnotations;

namespace AppEntityCore.Models
{
    public class Categoria
    {
        [Key]
      public int Id { get; set; }
        [Required]
        [StringLength(50)]
      public string? NombreCategoria { get; set; }

        public ICollection <Producto>? Productos { get; set; }
    }
}
