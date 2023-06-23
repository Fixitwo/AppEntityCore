using AppEntityCore.Models;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

namespace AppEntityCore.Datos
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> opciones) : base(opciones)
        {
            
        }
        //Aca vamos a escribir los modelos
        public DbSet<Categoria>Categorias { get; set; }
        public DbSet<Producto>Productos { get; set; }
        public DbSet<Pedido>Pedidos { get; set; }
        public DbSet<Usuario>Usuarios { get; set; }
        // N-1 con Categoria
        public DbSet<Articulo>Articulos { get; set; }
        //1-1 con usuario
        public DbSet<DetalleUsuario>DetalleUsuarios { get; set; }

        //Crear primary key de N-N / 2 claves primarias
        public DbSet<Etiqueta>Etiquetas { get; set; }
        protected override void OnModelCreating  (ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ArticuloEtiqueta>().HasKey(ae => new { ae.EtiquetaId, ae.ArticuloId });
        }

        
    }
}
