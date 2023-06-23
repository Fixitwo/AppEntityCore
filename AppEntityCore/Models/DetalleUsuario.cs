using System.ComponentModel.DataAnnotations.Schema;

namespace AppEntityCore.Models
{
    public class DetalleUsuario
    {
        public int DetalleUsuarioId { get; set; }
        public int Cedula { get; set; } 
        public string? Deporte { get; set; }
        public string? Mascota { get; set; }
        public Usuario? Usuario { get; set; }   



        
    }
}
