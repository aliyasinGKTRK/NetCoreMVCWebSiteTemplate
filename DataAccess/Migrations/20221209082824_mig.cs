using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class mig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Ozellik1",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Ozellik2",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Ozellik3",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Ozellik4",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Ozellik5",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OzellikDeger1",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OzellikDeger2",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OzellikDeger3",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OzellikDeger4",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OzellikDeger5",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProductDescriptionDe",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProductDescriptionEng",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProductNameDe",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProductNameEng",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Ozellik1",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Ozellik2",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Ozellik3",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Ozellik4",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Ozellik5",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "OzellikDeger1",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "OzellikDeger2",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "OzellikDeger3",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "OzellikDeger4",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "OzellikDeger5",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ProductDescriptionDe",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ProductDescriptionEng",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ProductNameDe",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ProductNameEng",
                table: "Products");
        }
    }
}
