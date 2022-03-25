using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SepahMD.DataLayer.Migrations
{
    public partial class CreateDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tblCity",
                columns: table => new
                {
                    CityID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProvinceName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CityName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Precode = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblCity", x => x.CityID);
                });

            migrationBuilder.CreateTable(
                name: "tblDoctorType",
                columns: table => new
                {
                    DoctorTypeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DoctorTypeName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblDoctorType", x => x.DoctorTypeID);
                });

            migrationBuilder.CreateTable(
                name: "tblInsurance",
                columns: table => new
                {
                    InsuranceID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InsuranceName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InsuranceDesc = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblInsurance", x => x.InsuranceID);
                });

            migrationBuilder.CreateTable(
                name: "tblDoctors",
                columns: table => new
                {
                    DoctorID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DoctorName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DoctorTell = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DoctorAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CityID = table.Column<int>(type: "int", nullable: false),
                    InsuranceID = table.Column<int>(type: "int", nullable: false),
                    DoctorTypeID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblDoctors", x => x.DoctorID);
                    table.ForeignKey(
                        name: "FK_tblDoctors_tblCity_CityID",
                        column: x => x.CityID,
                        principalTable: "tblCity",
                        principalColumn: "CityID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblDoctors_tblDoctorType_DoctorTypeID",
                        column: x => x.DoctorTypeID,
                        principalTable: "tblDoctorType",
                        principalColumn: "DoctorTypeID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblDoctors_tblInsurance_InsuranceID",
                        column: x => x.InsuranceID,
                        principalTable: "tblInsurance",
                        principalColumn: "InsuranceID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tblDoctors_CityID",
                table: "tblDoctors",
                column: "CityID");

            migrationBuilder.CreateIndex(
                name: "IX_tblDoctors_DoctorTypeID",
                table: "tblDoctors",
                column: "DoctorTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_tblDoctors_InsuranceID",
                table: "tblDoctors",
                column: "InsuranceID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblDoctors");

            migrationBuilder.DropTable(
                name: "tblCity");

            migrationBuilder.DropTable(
                name: "tblDoctorType");

            migrationBuilder.DropTable(
                name: "tblInsurance");
        }
    }
}
