using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EDSU_SMS.Data.Migrations
{
    public partial class RemoveInheritance : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Applicant");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Applicant",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
