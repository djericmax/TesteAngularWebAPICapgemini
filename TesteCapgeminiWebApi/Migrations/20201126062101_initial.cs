using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TesteCapgeminiWebApi.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Excel",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DtEntrega = table.Column<DateTime>(nullable: false),
                    NomeProduto = table.Column<string>(maxLength: 50, nullable: false),
                    Quantidade = table.Column<int>(type: "int", nullable: false),
                    ValorUnitario = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Excel", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Excel",
                columns: new[] { "Id", "DtEntrega", "NomeProduto", "Quantidade", "ValorUnitario" },
                values: new object[] { 1, new DateTime(2020, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Descrição 1", 1, 10m });

            migrationBuilder.InsertData(
                table: "Excel",
                columns: new[] { "Id", "DtEntrega", "NomeProduto", "Quantidade", "ValorUnitario" },
                values: new object[] { 2, new DateTime(2020, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Descrição 2", 2, 11m });

            migrationBuilder.InsertData(
                table: "Excel",
                columns: new[] { "Id", "DtEntrega", "NomeProduto", "Quantidade", "ValorUnitario" },
                values: new object[] { 3, new DateTime(2020, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Descrição 3", 3, 12m });

            migrationBuilder.InsertData(
                table: "Excel",
                columns: new[] { "Id", "DtEntrega", "NomeProduto", "Quantidade", "ValorUnitario" },
                values: new object[] { 4, new DateTime(2020, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Descrição 4", 4, 13m });

            migrationBuilder.InsertData(
                table: "Excel",
                columns: new[] { "Id", "DtEntrega", "NomeProduto", "Quantidade", "ValorUnitario" },
                values: new object[] { 5, new DateTime(2020, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Descrição 5", 5, 14m });

            migrationBuilder.InsertData(
                table: "Excel",
                columns: new[] { "Id", "DtEntrega", "NomeProduto", "Quantidade", "ValorUnitario" },
                values: new object[] { 6, new DateTime(2020, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Descrição 6", 6, 15m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Excel");
        }
    }
}
