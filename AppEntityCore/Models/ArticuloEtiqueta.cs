using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppEntityCore.Models
{
    public class ArticuloEtiqueta
    {
        [ForeignKey("Articulo")]
        public int ArticuloId { get; set; }

        [ForeignKey("Etiqueta")]
        public int EtiquetaId { get; set; }

        public Articulo? Articulo { get; set; }
        public Etiqueta? Etiqueta { get; set; }


    }
}
