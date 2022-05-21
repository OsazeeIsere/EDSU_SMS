using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EDSU_SMS.Data.Migrations
{
    public partial class MainMigration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Applicant",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "DirectEntryUpload",
                table: "Applicant",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LGAUpload",
                table: "Applicant",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UTEMTotal",
                table: "Applicant",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DirectEntryUpload",
                table: "Applicant");

            migrationBuilder.DropColumn(
                name: "LGAUpload",
                table: "Applicant");

            migrationBuilder.DropColumn(
                name: "UTEMTotal",
                table: "Applicant");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Applicant",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
