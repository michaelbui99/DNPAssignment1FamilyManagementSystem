using Microsoft.EntityFrameworkCore.Migrations;

namespace FamilyManagementRestApi.Migrations
{
    public partial class _1_Adults : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Adult_Families_FamilyStreetName_FamilyHouseNumber",
                table: "Adult");

            migrationBuilder.DropForeignKey(
                name: "FK_Adult_Job_JobTitle_JobSalary",
                table: "Adult");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Adult",
                table: "Adult");

            migrationBuilder.RenameTable(
                name: "Adult",
                newName: "Adults");

            migrationBuilder.RenameIndex(
                name: "IX_Adult_JobTitle_JobSalary",
                table: "Adults",
                newName: "IX_Adults_JobTitle_JobSalary");

            migrationBuilder.RenameIndex(
                name: "IX_Adult_FamilyStreetName_FamilyHouseNumber",
                table: "Adults",
                newName: "IX_Adults_FamilyStreetName_FamilyHouseNumber");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Adults",
                table: "Adults",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Adults_Families_FamilyStreetName_FamilyHouseNumber",
                table: "Adults",
                columns: new[] { "FamilyStreetName", "FamilyHouseNumber" },
                principalTable: "Families",
                principalColumns: new[] { "StreetName", "HouseNumber" },
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Adults_Job_JobTitle_JobSalary",
                table: "Adults",
                columns: new[] { "JobTitle", "JobSalary" },
                principalTable: "Job",
                principalColumns: new[] { "JobTitle", "Salary" },
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Adults_Families_FamilyStreetName_FamilyHouseNumber",
                table: "Adults");

            migrationBuilder.DropForeignKey(
                name: "FK_Adults_Job_JobTitle_JobSalary",
                table: "Adults");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Adults",
                table: "Adults");

            migrationBuilder.RenameTable(
                name: "Adults",
                newName: "Adult");

            migrationBuilder.RenameIndex(
                name: "IX_Adults_JobTitle_JobSalary",
                table: "Adult",
                newName: "IX_Adult_JobTitle_JobSalary");

            migrationBuilder.RenameIndex(
                name: "IX_Adults_FamilyStreetName_FamilyHouseNumber",
                table: "Adult",
                newName: "IX_Adult_FamilyStreetName_FamilyHouseNumber");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Adult",
                table: "Adult",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Adult_Families_FamilyStreetName_FamilyHouseNumber",
                table: "Adult",
                columns: new[] { "FamilyStreetName", "FamilyHouseNumber" },
                principalTable: "Families",
                principalColumns: new[] { "StreetName", "HouseNumber" },
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Adult_Job_JobTitle_JobSalary",
                table: "Adult",
                columns: new[] { "JobTitle", "JobSalary" },
                principalTable: "Job",
                principalColumns: new[] { "JobTitle", "Salary" },
                onDelete: ReferentialAction.Restrict);
        }
    }
}
