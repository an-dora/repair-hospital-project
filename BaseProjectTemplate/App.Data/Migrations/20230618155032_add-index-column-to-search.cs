using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace App.Data.Migrations
{
    public partial class addindexcolumntosearch : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_AppCompanyPatient_EmployeeCode",
                table: "AppCompanyPatient",
                column: "EmployeeCode");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_AppCompanyPatient_EmployeeCode",
                table: "AppCompanyPatient");
        }
    }
}
