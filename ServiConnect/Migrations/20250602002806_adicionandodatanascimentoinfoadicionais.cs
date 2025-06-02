using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ServiConnect.Migrations
{
    /// <inheritdoc />
    public partial class adicionandodatanascimentoinfoadicionais : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DataNascimento",
                table: "Login",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "InformacoesAdicionais",
                table: "Login",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataNascimento",
                table: "Login");

            migrationBuilder.DropColumn(
                name: "InformacoesAdicionais",
                table: "Login");
        }
    }
}
