using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Api.Persistencia.Migraciones
{
    /// <inheritdoc />
    public partial class DataSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Domicilio",
                columns: new[] { "Calle", "Altura", "CodigoPostal" },
                values: new object[,]
                {
                    { "Domicilio1", 1, 1 },
                    { "Domicilio2", 2, 2 }
                });

            migrationBuilder.InsertData(
                table: "Usuario",
                columns: new[] { "Direccion", "Apellido", "Nombre" },
                values: new object[,]
                {
                    { "Dirección1", "ApellidoA", "Usuario1" },
                    { "Dirección2", "ApellidoB", "Usuario2" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Domicilio",
                keyColumn: "Calle",
                keyValue: "Domicilio1");

            migrationBuilder.DeleteData(
                table: "Domicilio",
                keyColumn: "Calle",
                keyValue: "Domicilio2");

            migrationBuilder.DeleteData(
                table: "Usuario",
                keyColumn: "Direccion",
                keyValue: "Dirección1");

            migrationBuilder.DeleteData(
                table: "Usuario",
                keyColumn: "Direccion",
                keyValue: "Dirección2");
        }
    }
}
