using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MagicVilla_API.Migrations
{
    /// <inheritdoc />
    public partial class AlimentarTablaVilla : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Villas",
                columns: new[] { "Id", "Amenidad", "Detalle", "FechaActualizacion", "FechaCreacion", "ImagenUrl", "MetrosCuadrados", "Nombre", "Ocupantes", "Tarifa" },
                values: new object[,]
                {
                    { 1, "", "Detalle de la Villa Real...", new DateTime(2024, 2, 26, 18, 56, 22, 523, DateTimeKind.Local).AddTicks(8965), new DateTime(2024, 2, 26, 18, 56, 22, 523, DateTimeKind.Local).AddTicks(8947), "", 40, "Villa Real", 5, 200.0 },
                    { 2, "", "Detalle de la Villa Maria...", new DateTime(2024, 2, 26, 18, 56, 22, 523, DateTimeKind.Local).AddTicks(8972), new DateTime(2024, 2, 26, 18, 56, 22, 523, DateTimeKind.Local).AddTicks(8970), "", 50, "Villa Maria", 6, 300.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
