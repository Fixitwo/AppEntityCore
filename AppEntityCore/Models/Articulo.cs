using System.ComponentModel.DataAnnotations.Schema;

namespace AppEntityCore.Models
{
    public class Articulo
    {
        public int ArticuloId { get; set; }
        public string? Tipo { get; set; }
        public string? Descripcion { get; set; }
        public string? Fecha { get; set; }

        [ForeignKey("Categoria")]
        public int? CategoriaId { get; set; }
        public Categoria? Categoria { get; set; }

        //Conexion con etiquet
        public ICollection <ArticuloEtiqueta>? ArticuloEtiqueta { get; set;}

    }
}
