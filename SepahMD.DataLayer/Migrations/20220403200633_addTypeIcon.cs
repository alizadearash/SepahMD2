using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SepahMD.DataLayer.Migrations
{
    public partial class addTypeIcon : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DoctorTypeIcon",
                table: "tblDoctorType",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DoctorTypeIcon",
                table: "tblDoctorType");
        }
    }
}
