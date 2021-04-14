using Microsoft.EntityFrameworkCore.Migrations;

namespace SchoolBussWebApp.Migrations.BussDb
{
    public partial class CreateBussSchema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BussAtnd",
                columns: table => new
                {
                    Schl_Year = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    Schl_Shtm = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    Stnt_Numb = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Buss_Code = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: true),
                    Stnt_Hand = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: true),
                    Aply_Date = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: true),
                    Aply_Numb = table.Column<decimal>(type: "decimal(18,0)", nullable: false),
                    Aply_Amnt = table.Column<decimal>(type: "decimal(18,0)", nullable: false),
                    Remk_Text = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Inpt_Date = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Updt_Date = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Aply_Stat = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: true),
                    Aply_Type = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BussAtnd", x => new { x.Schl_Year, x.Schl_Shtm, x.Stnt_Numb });
                });

            migrationBuilder.CreateTable(
                name: "BussCard",
                columns: table => new
                {
                    Card_Uuid = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Seq = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Buss_Code = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: true),
                    Buss_Line = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Issu_Numb = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: true),
                    Card_Prob = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: true),
                    Card_Stat = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BussCard", x => x.Card_Uuid);
                });

            migrationBuilder.CreateTable(
                name: "BussCardIssu",
                columns: table => new
                {
                    Issu_Year = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    Issu_Shtm = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    Stnt_Numb = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Buss_Code = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: true),
                    Korn_Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Issu_Numb = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: true),
                    Dpst_Amnt = table.Column<decimal>(type: "decimal(18,0)", nullable: false),
                    Buss_Fees = table.Column<decimal>(type: "decimal(18,0)", nullable: false),
                    Regi_Amnt = table.Column<decimal>(type: "decimal(18,0)", nullable: false),
                    Issu_Date = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Issu_Type = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: true),
                    Issu_Stat = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: true),
                    Stat_Date = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BussCardIssu", x => new { x.Issu_Year, x.Issu_Shtm, x.Stnt_Numb });
                });

            migrationBuilder.CreateTable(
                name: "BussLine",
                columns: table => new
                {
                    Seq = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Schl_Year = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    Schl_Shtm = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true),
                    Buss_Code = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: true),
                    Buss_line = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Buss_Fees = table.Column<decimal>(type: "decimal(18,0)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BussLine", x => x.Seq);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BussAtnd");

            migrationBuilder.DropTable(
                name: "BussCard");

            migrationBuilder.DropTable(
                name: "BussCardIssu");

            migrationBuilder.DropTable(
                name: "BussLine");
        }
    }
}
