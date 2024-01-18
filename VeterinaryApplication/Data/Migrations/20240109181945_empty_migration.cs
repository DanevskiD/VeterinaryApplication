using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VeterinaryApplication.Data.Migrations
{
    /// <inheritdoc />
    public partial class empty_migration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pet_Owner_OwnerId",
                table: "Pet");

            migrationBuilder.DropForeignKey(
                name: "FK_PetVaccine_Pet_PetsPetId",
                table: "PetVaccine");

            migrationBuilder.DropForeignKey(
                name: "FK_PetVaccine_Vaccine_VaccinesVaccineId",
                table: "PetVaccine");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Vaccine",
                table: "Vaccine");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pet",
                table: "Pet");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Owner",
                table: "Owner");

            migrationBuilder.RenameTable(
                name: "Vaccine",
                newName: "Vaccines");

            migrationBuilder.RenameTable(
                name: "Pet",
                newName: "Pets");

            migrationBuilder.RenameTable(
                name: "Owner",
                newName: "Owners");

            migrationBuilder.RenameIndex(
                name: "IX_Pet_OwnerId",
                table: "Pets",
                newName: "IX_Pets_OwnerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Vaccines",
                table: "Vaccines",
                column: "VaccineId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pets",
                table: "Pets",
                column: "PetId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Owners",
                table: "Owners",
                column: "OwnerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pets_Owners_OwnerId",
                table: "Pets",
                column: "OwnerId",
                principalTable: "Owners",
                principalColumn: "OwnerId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PetVaccine_Pets_PetsPetId",
                table: "PetVaccine",
                column: "PetsPetId",
                principalTable: "Pets",
                principalColumn: "PetId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PetVaccine_Vaccines_VaccinesVaccineId",
                table: "PetVaccine",
                column: "VaccinesVaccineId",
                principalTable: "Vaccines",
                principalColumn: "VaccineId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pets_Owners_OwnerId",
                table: "Pets");

            migrationBuilder.DropForeignKey(
                name: "FK_PetVaccine_Pets_PetsPetId",
                table: "PetVaccine");

            migrationBuilder.DropForeignKey(
                name: "FK_PetVaccine_Vaccines_VaccinesVaccineId",
                table: "PetVaccine");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Vaccines",
                table: "Vaccines");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pets",
                table: "Pets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Owners",
                table: "Owners");

            migrationBuilder.RenameTable(
                name: "Vaccines",
                newName: "Vaccine");

            migrationBuilder.RenameTable(
                name: "Pets",
                newName: "Pet");

            migrationBuilder.RenameTable(
                name: "Owners",
                newName: "Owner");

            migrationBuilder.RenameIndex(
                name: "IX_Pets_OwnerId",
                table: "Pet",
                newName: "IX_Pet_OwnerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Vaccine",
                table: "Vaccine",
                column: "VaccineId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pet",
                table: "Pet",
                column: "PetId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Owner",
                table: "Owner",
                column: "OwnerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pet_Owner_OwnerId",
                table: "Pet",
                column: "OwnerId",
                principalTable: "Owner",
                principalColumn: "OwnerId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PetVaccine_Pet_PetsPetId",
                table: "PetVaccine",
                column: "PetsPetId",
                principalTable: "Pet",
                principalColumn: "PetId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PetVaccine_Vaccine_VaccinesVaccineId",
                table: "PetVaccine",
                column: "VaccinesVaccineId",
                principalTable: "Vaccine",
                principalColumn: "VaccineId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
