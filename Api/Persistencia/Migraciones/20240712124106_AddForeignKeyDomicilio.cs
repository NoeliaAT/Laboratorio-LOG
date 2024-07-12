using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Api.Persistencia.Migraciones
{
    /// <inheritdoc />
    public partial class AddForeignKeyDomicilio : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Domicilio",
                keyColumn: "Id",
                keyValue: new Guid("3402dc15-f2f4-4591-baa4-b8a1359e009f"));

            migrationBuilder.DeleteData(
                table: "Domicilio",
                keyColumn: "Id",
                keyValue: new Guid("743ffdc7-63a0-41f1-ac14-a7ee9068c1ff"));

            migrationBuilder.DeleteData(
                table: "Usuario",
                keyColumn: "Id",
                keyValue: new Guid("ef16780f-0858-45dc-a63f-243e39c0e8d8"));

            migrationBuilder.DeleteData(
                table: "Usuario",
                keyColumn: "Id",
                keyValue: new Guid("f0f6ac84-903f-4416-bcc4-e772bf702e38"));

            migrationBuilder.AddColumn<Guid>(
                name: "IdDomicilio",
                table: "Usuario",
                type: "char(36)",
                nullable: true,
                collation: "ascii_general_ci");

            migrationBuilder.InsertData(
                table: "Domicilio",
                columns: new[] { "Id", "Altura", "Calle", "CodigoPostal" },
                values: new object[,]
                {
                    { new Guid("39d3ff4d-5e01-4a42-a7b9-59f4b71beec9"), 1, "Domicilio1", 1 },
                    { new Guid("ac495f01-1cab-43f9-ab70-b38d8e1ed1c4"), 2, "Domicilio2", 2 }
                });

            migrationBuilder.InsertData(
                table: "Usuario",
                columns: new[] { "Id", "Apellido", "Direccion", "IdDomicilio", "Nombre" },
                values: new object[,]
                {
                    { new Guid("657d5a0e-bf98-4d84-b949-9092d453daa5"), "ApellidoA", "Dirección1", null, "Usuario1" },
                    { new Guid("b00946b8-93cd-4c24-9083-23f1cd3bc6c9"), "ApellidoB", "Dirección2", null, "Usuario2" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_IdDomicilio",
                table: "Usuario",
                column: "IdDomicilio");

            migrationBuilder.AddForeignKey(
                name: "FK_Usuario_Domicilio_IdDomicilio",
                table: "Usuario",
                column: "IdDomicilio",
                principalTable: "Domicilio",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Usuario_Domicilio_IdDomicilio",
                table: "Usuario");

            migrationBuilder.DropIndex(
                name: "IX_Usuario_IdDomicilio",
                table: "Usuario");

            migrationBuilder.DeleteData(
                table: "Domicilio",
                keyColumn: "Id",
                keyValue: new Guid("39d3ff4d-5e01-4a42-a7b9-59f4b71beec9"));

            migrationBuilder.DeleteData(
                table: "Domicilio",
                keyColumn: "Id",
                keyValue: new Guid("ac495f01-1cab-43f9-ab70-b38d8e1ed1c4"));

            migrationBuilder.DeleteData(
                table: "Usuario",
                keyColumn: "Id",
                keyValue: new Guid("657d5a0e-bf98-4d84-b949-9092d453daa5"));

            migrationBuilder.DeleteData(
                table: "Usuario",
                keyColumn: "Id",
                keyValue: new Guid("b00946b8-93cd-4c24-9083-23f1cd3bc6c9"));

            migrationBuilder.DropColumn(
                name: "IdDomicilio",
                table: "Usuario");

            migrationBuilder.InsertData(
                table: "Domicilio",
                columns: new[] { "Id", "Altura", "Calle", "CodigoPostal" },
                values: new object[,]
                {
                    { new Guid("3402dc15-f2f4-4591-baa4-b8a1359e009f"), 1, "Domicilio1", 1 },
                    { new Guid("743ffdc7-63a0-41f1-ac14-a7ee9068c1ff"), 2, "Domicilio2", 2 }
                });

            migrationBuilder.InsertData(
                table: "Usuario",
                columns: new[] { "Id", "Apellido", "Direccion", "Nombre" },
                values: new object[,]
                {
                    { new Guid("ef16780f-0858-45dc-a63f-243e39c0e8d8"), "ApellidoB", "Dirección2", "Usuario2" },
                    { new Guid("f0f6ac84-903f-4416-bcc4-e772bf702e38"), "ApellidoA", "Dirección1", "Usuario1" }
                });
        }
    }
}
