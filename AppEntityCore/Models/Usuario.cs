using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppEntityCore.Models
{
    public class Usuario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Display(Name = "Nombre")]
        public string? Nombre { get; set; }

        public DateTime FechNac { get;}

        [NotMapped]
        public int Edad { get; set; }

        [Display(Name ="Correo electronico")]

        [ForeignKey("DetalleUsuario")]
        public int DetalleUsuarioId { get;}
        public DetalleUsuario? DetalleUsuario { get; set; }
    }
}
