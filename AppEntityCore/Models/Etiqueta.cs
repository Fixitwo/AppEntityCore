using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppEntityCore.Models
{
    [Table (name:"Etiquetas")]
    public class Etiqueta
    {
        [Key]
        public int? EtiquetaId { get; set; }
        public string? Titulo { get; set; }
        [DataType(DataType.Date)]
        public DateTime? Fecha { get; set; }

        //conexion con articulo
        public ICollection<ArticuloEtiqueta>? ArticuloEtiqueta { get; set; }
    }
}
