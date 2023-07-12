using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace App.Data.Migrations
{
    public partial class addtableforimportexcel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppCompanyPatientImported",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeCode = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    FullName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    FullNameNoAccent = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    YoB = table.Column<int>(type: "int", nullable: true),
                    DoB = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IdentityCode = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    IdentityDoI = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IdentityPoI = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Address = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    DigitalInfo = table.Column<int>(type: "int", nullable: true),
                    DepartmentId = table.Column<int>(type: "int", nullable: true),
                    CompanyId = table.Column<int>(type: "int", nullable: true),
                    ImportDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDuplicate = table.Column<bool>(type: "bit", nullable: false),
                    DisplayOrder = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppCompanyPatientImported", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppCompanyPatientImported_AppCompany_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "AppCompany",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AppCompanyPatientImported_AppCompanyDepartment_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "AppCompanyDepartment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AppCompanyPatient_IdentityCode",
                table: "AppCompanyPatient",
                column: "IdentityCode");

            migrationBuilder.CreateIndex(
                name: "IX_AppCompanyPatientImported_CompanyId",
                table: "AppCompanyPatientImported",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_AppCompanyPatientImported_DepartmentId",
                table: "AppCompanyPatientImported",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_AppCompanyPatientImported_EmployeeCode",
                table: "AppCompanyPatientImported",
                column: "EmployeeCode");

            migrationBuilder.CreateIndex(
                name: "IX_AppCompanyPatientImported_IdentityCode",
                table: "AppCompanyPatientImported",
                column: "IdentityCode");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppCompanyPatientImported");

            migrationBuilder.DropIndex(
                name: "IX_AppCompanyPatient_IdentityCode",
                table: "AppCompanyPatient");
        }
    }
}
