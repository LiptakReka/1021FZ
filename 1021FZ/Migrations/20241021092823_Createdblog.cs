using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

namespace _1021FZ.Migrations
{
    /// <inheritdoc />
    public partial class Createdblog : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "dateat",
                table: "bloggers",
                type: "datetime(6)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2(6)");

            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "bloggers",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Sex",
                table: "bloggers",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "bloggers",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "bloggers",
                type: "char(36)",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier(36)");

            migrationBuilder.AddColumn<int>(
                name: "BlogRegistryId",
                table: "bloggers",
                type: "int",
                nullable: true);

            //migrationBuilder.AddColumn<string>(
            //    name: "gender",
            //    table: "bloggers",
            //    type: "longtext",
            //    nullable: false);

            migrationBuilder.CreateTable(
                name: "blogRegistry",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(type: "longtext", nullable: false),
                    createdat = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    updatedat = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    description = table.Column<string>(type: "longtext", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_blogRegistry", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            //migrationBuilder.CreateIndex(
            //    name: "IX_bloggers_BlogRegistryId",
            //    table: "bloggers",
            //    column: "BlogRegistryId");

            migrationBuilder.AddForeignKey(
                name: "FK_bloggers_blogRegistry_BlogRegistryId",
                table: "bloggers",
                column: "BlogRegistryId",
                principalTable: "blogRegistry",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_bloggers_blogRegistry_BlogRegistryId",
                table: "bloggers");

            migrationBuilder.DropTable(
                name: "blogRegistry");

            migrationBuilder.DropIndex(
                name: "IX_bloggers_BlogRegistryId",
                table: "bloggers");

            migrationBuilder.DropColumn(
                name: "BlogRegistryId",
                table: "bloggers");

            migrationBuilder.DropColumn(
                name: "gender",
                table: "bloggers");

            migrationBuilder.AlterColumn<DateTime>(
                name: "dateat",
                table: "bloggers",
                type: "datetime2(6)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)");

            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "bloggers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext");

            migrationBuilder.AlterColumn<string>(
                name: "Sex",
                table: "bloggers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "bloggers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "bloggers",
                type: "uniqueidentifier(36)",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "char(36)");
        }
    }
}
