using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VeterinaryApplication.Data.Migrations
{
    /// <inheritdoc />
    public partial class changed_letters : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "years",
                table: "Owner",
                newName: "Years");

            migrationBuilder.RenameColumn(
                name: "lastName",
                table: "Owner",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "firstName",
                table: "Owner",
                newName: "FirstName");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Vaccine",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Pet",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Owner",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Owner",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Years",
                table: "Owner",
                newName: "years");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Owner",
                newName: "lastName");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "Owner",
                newName: "firstName");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Vaccine",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Pet",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "lastName",
                table: "Owner",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "firstName",
                table: "Owner",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
