using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EDSU_SMS.Data.Migrations
{
    public partial class MainMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Phone",
                table: "Applicant",
                newName: "UTMESubject4");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Applicant",
                newName: "UTMESubject3");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Applicant",
                type: "nvarchar(max)",
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BirthCertificate",
                table: "Applicant",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ContactAddress",
                table: "Applicant",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CourseChoseInJamb",
                table: "Applicant",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DOB",
                table: "Applicant",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "FirstChoice",
                table: "Applicant",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Indigine",
                table: "Applicant",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Jamb",
                table: "Applicant",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LGA",
                table: "Applicant",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MaritalStatus",
                table: "Applicant",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModeOfEntry",
                table: "Applicant",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Nationality",
                table: "Applicant",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NoOfSittings",
                table: "Applicant",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ParentAddress",
                table: "Applicant",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ParentAlternatePhoneNumber",
                table: "Applicant",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ParentEmail",
                table: "Applicant",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ParentFullName",
                table: "Applicant",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ParentOccupation",
                table: "Applicant",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ParentPhoneNumber",
                table: "Applicant",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Passport",
                table: "Applicant",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PermanentHomeAddress",
                table: "Applicant",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Applicant",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PlaceOfBirth",
                table: "Applicant",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PreviousGrade",
                table: "Applicant",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PreviousInstitution",
                table: "Applicant",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PreviousLevel",
                table: "Applicant",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PrimarySchool",
                table: "Applicant",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SecondChoice",
                table: "Applicant",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SecondarySchool",
                table: "Applicant",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Sex",
                table: "Applicant",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Ssce1",
                table: "Applicant",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Ssce1Number",
                table: "Applicant",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Ssce1Subject1",
                table: "Applicant",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Ssce1Subject1Grade",
                table: "Applicant",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Ssce1Subject2",
                table: "Applicant",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Ssce1Subject2Grade",
                table: "Applicant",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Ssce1Subject3",
                table: "Applicant",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Ssce1Subject3Grade",
                table: "Applicant",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Ssce1Subject4",
                table: "Applicant",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Ssce1Subject4Grade",
                table: "Applicant",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Ssce1Subject5",
                table: "Applicant",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Ssce1Subject5Grade",
                table: "Applicant",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Ssce1Subject6",
                table: "Applicant",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Ssce1Subject6Grade",
                table: "Applicant",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Ssce1Subject7",
                table: "Applicant",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Ssce1Subject7Grade",
                table: "Applicant",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Ssce1Subject8",
                table: "Applicant",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Ssce1Subject8Grade",
                table: "Applicant",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Ssce1Subject9",
                table: "Applicant",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Ssce1Subject9Grade",
                table: "Applicant",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Ssce1Type",
                table: "Applicant",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Ssce1Year",
                table: "Applicant",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Ssce2",
                table: "Applicant",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Ssce2Number",
                table: "Applicant",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Ssce2Subject1",
                table: "Applicant",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Ssce2Subject1Grade",
                table: "Applicant",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Ssce2Subject2",
                table: "Applicant",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Ssce2Subject2Grade",
                table: "Applicant",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Ssce2Subject3",
                table: "Applicant",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Ssce2Subject3Grade",
                table: "Applicant",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Ssce2Subject4",
                table: "Applicant",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Ssce2Subject4Grade",
                table: "Applicant",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Ssce2Subject5",
                table: "Applicant",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Ssce2Subject5Grade",
                table: "Applicant",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Ssce2Subject6",
                table: "Applicant",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Ssce2Subject6Grade",
                table: "Applicant",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Ssce2Subject7",
                table: "Applicant",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Ssce2Subject7Grade",
                table: "Applicant",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Ssce2Subject8",
                table: "Applicant",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Ssce2Subject8Grade",
                table: "Applicant",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Ssce2Subject9",
                table: "Applicant",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Ssce2Subject9Grade",
                table: "Applicant",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Ssce2Type",
                table: "Applicant",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Ssce2Year",
                table: "Applicant",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "StateOfOrigin",
                table: "Applicant",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Surname",
                table: "Applicant",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ThirdChoice",
                table: "Applicant",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UTMESubject1",
                table: "Applicant",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UTMESubject1Score",
                table: "Applicant",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "UTMESubject2",
                table: "Applicant",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UTMESubject2Score",
                table: "Applicant",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UTMESubject3Score",
                table: "Applicant",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UTMESubject4Score",
                table: "Applicant",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BirthCertificate",
                table: "Applicant");

            migrationBuilder.DropColumn(
                name: "ContactAddress",
                table: "Applicant");

            migrationBuilder.DropColumn(
                name: "CourseChoseInJamb",
                table: "Applicant");

            migrationBuilder.DropColumn(
                name: "DOB",
                table: "Applicant");

            migrationBuilder.DropColumn(
                name: "FirstChoice",
                table: "Applicant");

            migrationBuilder.DropColumn(
                name: "Indigine",
                table: "Applicant");

            migrationBuilder.DropColumn(
                name: "Jamb",
                table: "Applicant");

            migrationBuilder.DropColumn(
                name: "LGA",
                table: "Applicant");

            migrationBuilder.DropColumn(
                name: "MaritalStatus",
                table: "Applicant");

            migrationBuilder.DropColumn(
                name: "ModeOfEntry",
                table: "Applicant");

            migrationBuilder.DropColumn(
                name: "Nationality",
                table: "Applicant");

            migrationBuilder.DropColumn(
                name: "NoOfSittings",
                table: "Applicant");

            migrationBuilder.DropColumn(
                name: "ParentAddress",
                table: "Applicant");

            migrationBuilder.DropColumn(
                name: "ParentAlternatePhoneNumber",
                table: "Applicant");

            migrationBuilder.DropColumn(
                name: "ParentEmail",
                table: "Applicant");

            migrationBuilder.DropColumn(
                name: "ParentFullName",
                table: "Applicant");

            migrationBuilder.DropColumn(
                name: "ParentOccupation",
                table: "Applicant");

            migrationBuilder.DropColumn(
                name: "ParentPhoneNumber",
                table: "Applicant");

            migrationBuilder.DropColumn(
                name: "Passport",
                table: "Applicant");

            migrationBuilder.DropColumn(
                name: "PermanentHomeAddress",
                table: "Applicant");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Applicant");

            migrationBuilder.DropColumn(
                name: "PlaceOfBirth",
                table: "Applicant");

            migrationBuilder.DropColumn(
                name: "PreviousGrade",
                table: "Applicant");

            migrationBuilder.DropColumn(
                name: "PreviousInstitution",
                table: "Applicant");

            migrationBuilder.DropColumn(
                name: "PreviousLevel",
                table: "Applicant");

            migrationBuilder.DropColumn(
                name: "PrimarySchool",
                table: "Applicant");

            migrationBuilder.DropColumn(
                name: "SecondChoice",
                table: "Applicant");

            migrationBuilder.DropColumn(
                name: "SecondarySchool",
                table: "Applicant");

            migrationBuilder.DropColumn(
                name: "Sex",
                table: "Applicant");

            migrationBuilder.DropColumn(
                name: "Ssce1",
                table: "Applicant");

            migrationBuilder.DropColumn(
                name: "Ssce1Number",
                table: "Applicant");

            migrationBuilder.DropColumn(
                name: "Ssce1Subject1",
                table: "Applicant");

            migrationBuilder.DropColumn(
                name: "Ssce1Subject1Grade",
                table: "Applicant");

            migrationBuilder.DropColumn(
                name: "Ssce1Subject2",
                table: "Applicant");

            migrationBuilder.DropColumn(
                name: "Ssce1Subject2Grade",
                table: "Applicant");

            migrationBuilder.DropColumn(
                name: "Ssce1Subject3",
                table: "Applicant");

            migrationBuilder.DropColumn(
                name: "Ssce1Subject3Grade",
                table: "Applicant");

            migrationBuilder.DropColumn(
                name: "Ssce1Subject4",
                table: "Applicant");

            migrationBuilder.DropColumn(
                name: "Ssce1Subject4Grade",
                table: "Applicant");

            migrationBuilder.DropColumn(
                name: "Ssce1Subject5",
                table: "Applicant");

            migrationBuilder.DropColumn(
                name: "Ssce1Subject5Grade",
                table: "Applicant");

            migrationBuilder.DropColumn(
                name: "Ssce1Subject6",
                table: "Applicant");

            migrationBuilder.DropColumn(
                name: "Ssce1Subject6Grade",
                table: "Applicant");

            migrationBuilder.DropColumn(
                name: "Ssce1Subject7",
                table: "Applicant");

            migrationBuilder.DropColumn(
                name: "Ssce1Subject7Grade",
                table: "Applicant");

            migrationBuilder.DropColumn(
                name: "Ssce1Subject8",
                table: "Applicant");

            migrationBuilder.DropColumn(
                name: "Ssce1Subject8Grade",
                table: "Applicant");

            migrationBuilder.DropColumn(
                name: "Ssce1Subject9",
                table: "Applicant");

            migrationBuilder.DropColumn(
                name: "Ssce1Subject9Grade",
                table: "Applicant");

            migrationBuilder.DropColumn(
                name: "Ssce1Type",
                table: "Applicant");

            migrationBuilder.DropColumn(
                name: "Ssce1Year",
                table: "Applicant");

            migrationBuilder.DropColumn(
                name: "Ssce2",
                table: "Applicant");

            migrationBuilder.DropColumn(
                name: "Ssce2Number",
                table: "Applicant");

            migrationBuilder.DropColumn(
                name: "Ssce2Subject1",
                table: "Applicant");

            migrationBuilder.DropColumn(
                name: "Ssce2Subject1Grade",
                table: "Applicant");

            migrationBuilder.DropColumn(
                name: "Ssce2Subject2",
                table: "Applicant");

            migrationBuilder.DropColumn(
                name: "Ssce2Subject2Grade",
                table: "Applicant");

            migrationBuilder.DropColumn(
                name: "Ssce2Subject3",
                table: "Applicant");

            migrationBuilder.DropColumn(
                name: "Ssce2Subject3Grade",
                table: "Applicant");

            migrationBuilder.DropColumn(
                name: "Ssce2Subject4",
                table: "Applicant");

            migrationBuilder.DropColumn(
                name: "Ssce2Subject4Grade",
                table: "Applicant");

            migrationBuilder.DropColumn(
                name: "Ssce2Subject5",
                table: "Applicant");

            migrationBuilder.DropColumn(
                name: "Ssce2Subject5Grade",
                table: "Applicant");

            migrationBuilder.DropColumn(
                name: "Ssce2Subject6",
                table: "Applicant");

            migrationBuilder.DropColumn(
                name: "Ssce2Subject6Grade",
                table: "Applicant");

            migrationBuilder.DropColumn(
                name: "Ssce2Subject7",
                table: "Applicant");

            migrationBuilder.DropColumn(
                name: "Ssce2Subject7Grade",
                table: "Applicant");

            migrationBuilder.DropColumn(
                name: "Ssce2Subject8",
                table: "Applicant");

            migrationBuilder.DropColumn(
                name: "Ssce2Subject8Grade",
                table: "Applicant");

            migrationBuilder.DropColumn(
                name: "Ssce2Subject9",
                table: "Applicant");

            migrationBuilder.DropColumn(
                name: "Ssce2Subject9Grade",
                table: "Applicant");

            migrationBuilder.DropColumn(
                name: "Ssce2Type",
                table: "Applicant");

            migrationBuilder.DropColumn(
                name: "Ssce2Year",
                table: "Applicant");

            migrationBuilder.DropColumn(
                name: "StateOfOrigin",
                table: "Applicant");

            migrationBuilder.DropColumn(
                name: "Surname",
                table: "Applicant");

            migrationBuilder.DropColumn(
                name: "ThirdChoice",
                table: "Applicant");

            migrationBuilder.DropColumn(
                name: "UTMESubject1",
                table: "Applicant");

            migrationBuilder.DropColumn(
                name: "UTMESubject1Score",
                table: "Applicant");

            migrationBuilder.DropColumn(
                name: "UTMESubject2",
                table: "Applicant");

            migrationBuilder.DropColumn(
                name: "UTMESubject2Score",
                table: "Applicant");

            migrationBuilder.DropColumn(
                name: "UTMESubject3Score",
                table: "Applicant");

            migrationBuilder.DropColumn(
                name: "UTMESubject4Score",
                table: "Applicant");

            migrationBuilder.RenameColumn(
                name: "UTMESubject4",
                table: "Applicant",
                newName: "Phone");

            migrationBuilder.RenameColumn(
                name: "UTMESubject3",
                table: "Applicant",
                newName: "LastName");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Applicant",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
