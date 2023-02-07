using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class mig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Ozellik1De",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Ozellik1Eng",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Ozellik2De",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Ozellik2Eng",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Ozellik3De",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Ozellik3Eng",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Ozellik4De",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Ozellik4Eng",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Ozellik5De",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Ozellik5Eng",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OzellikDeger1De",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OzellikDeger1Eng",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OzellikDeger2De",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OzellikDeger2Eng",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OzellikDeger3De",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OzellikDeger3Eng",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OzellikDeger4De",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OzellikDeger4Eng",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OzellikDeger5De",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OzellikDeger5Eng",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TumbNameDe",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TumbNameEng",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ozellik1De",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Ozellik1Eng",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Ozellik2De",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Ozellik2Eng",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Ozellik3De",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Ozellik3Eng",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Ozellik4De",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Ozellik4Eng",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Ozellik5De",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Ozellik5Eng",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "OzellikDeger1De",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "OzellikDeger1Eng",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "OzellikDeger2De",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "OzellikDeger2Eng",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "OzellikDeger3De",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "OzellikDeger3Eng",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "OzellikDeger4De",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "OzellikDeger4Eng",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "OzellikDeger5De",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "OzellikDeger5Eng",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "TumbNameDe",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "TumbNameEng",
                table: "Products");
        }
    }
}
