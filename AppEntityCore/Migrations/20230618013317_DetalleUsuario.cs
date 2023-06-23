using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AppEntityCore.Migrations
{
    public partial class DetalleUsuario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DetalleUsuarioId",
                table: "Usuarios",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CategoriaId",
                table: "Articulos",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "DetalleUsuarios",
                columns: table => new
                {
                    DetalleUsuarioId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cedula = table.Column<int>(type: "int", nullable: false),
                    Deporte = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mascota = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetalleUsuarios", x => x.DetalleUsuarioId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_DetalleUsuarioId",
                table: "Usuarios",
                column: "DetalleUsuarioId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Articulos_CategoriaId",
                table: "Articulos",
                column: "CategoriaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Articulos_Categorias_CategoriaId",
                table: "Articulos",
                column: "CategoriaId",
                principalTable: "Categorias",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_DetalleUsuarios_DetalleUsuarioId",
                table: "Usuarios",
                column: "DetalleUsuarioId",
                principalTable: "DetalleUsuarios",
                principalColumn: "DetalleUsuarioId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articulos_Categorias_CategoriaId",
                table: "Articulos");

            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_DetalleUsuarios_DetalleUsuarioId",
                table: "Usuarios");

            migrationBuilder.DropTable(
                name: "DetalleUsuarios");

            migrationBuilder.DropIndex(
                name: "IX_Usuarios_DetalleUsuarioId",
                table: "Usuarios");

            migrationBuilder.DropIndex(
                name: "IX_Articulos_CategoriaId",
                table: "Articulos");

            migrationBuilder.DropColumn(
                name: "DetalleUsuarioId",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "CategoriaId",
                table: "Articulos");
        }
    }
}
