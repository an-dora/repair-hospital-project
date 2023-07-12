using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace App.Data.Migrations
{
    public partial class add_col_CompanyId_tbl_AppCompanyPatient : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CompanyId",
                table: "AppCompanyPatient",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 119, 156, 202, 28, 211, 50, 170, 106, 146, 143, 230, 253, 38, 129, 122, 126, 83, 73, 217, 208, 227, 45, 249, 86, 241, 251, 213, 122, 70, 77, 243, 114, 98, 72, 200, 147, 174, 31, 214, 76, 131, 193, 12, 166, 15, 158, 39, 102, 88, 76, 240, 7, 126, 149, 84, 49, 7, 197, 165, 124, 145, 202, 181, 213 }, new byte[] { 211, 132, 209, 119, 90, 1, 99, 99, 213, 97, 125, 230, 11, 245, 9, 136, 126, 91, 77, 88, 235, 162, 86, 248, 133, 180, 208, 145, 34, 90, 248, 125, 208, 68, 37, 25, 7, 85, 150, 14, 231, 253, 236, 168, 119, 158, 119, 15, 78, 97, 66, 106, 68, 157, 249, 123, 238, 43, 236, 136, 113, 247, 10, 181, 219, 15, 20, 128, 24, 244, 234, 42, 252, 187, 186, 11, 163, 167, 223, 20, 31, 231, 158, 34, 82, 245, 228, 35, 12, 8, 237, 196, 132, 152, 215, 250, 83, 100, 159, 148, 188, 216, 211, 111, 99, 242, 7, 38, 161, 167, 28, 184, 6, 240, 124, 17, 88, 114, 197, 59, 18, 235, 199, 126, 232, 120, 149, 225 } });

            migrationBuilder.CreateIndex(
                name: "IX_AppCompanyPatient_CompanyId",
                table: "AppCompanyPatient",
                column: "CompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_AppCompanyPatient_AppCompany_CompanyId",
                table: "AppCompanyPatient",
                column: "CompanyId",
                principalTable: "AppCompany",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppCompanyPatient_AppCompany_CompanyId",
                table: "AppCompanyPatient");

            migrationBuilder.DropIndex(
                name: "IX_AppCompanyPatient_CompanyId",
                table: "AppCompanyPatient");

            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "AppCompanyPatient");

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 185, 74, 108, 0, 235, 133, 88, 65, 165, 213, 72, 29, 120, 56, 13, 71, 160, 71, 20, 50, 52, 95, 251, 65, 128, 185, 51, 169, 1, 18, 239, 43, 12, 185, 221, 76, 169, 227, 49, 224, 2, 7, 111, 175, 2, 59, 8, 195, 122, 237, 102, 132, 202, 131, 207, 218, 121, 200, 28, 238, 176, 22, 48, 42 }, new byte[] { 156, 181, 140, 121, 216, 201, 86, 161, 137, 201, 80, 128, 125, 93, 215, 49, 73, 219, 146, 194, 198, 245, 127, 160, 204, 93, 235, 35, 200, 190, 34, 8, 190, 196, 37, 241, 91, 179, 251, 135, 7, 29, 62, 202, 148, 95, 206, 53, 23, 8, 201, 54, 221, 39, 219, 93, 99, 130, 8, 224, 168, 203, 162, 14, 189, 212, 195, 92, 23, 148, 175, 166, 113, 125, 12, 220, 238, 113, 253, 82, 11, 124, 34, 241, 127, 97, 25, 187, 198, 102, 248, 103, 143, 106, 145, 137, 224, 31, 229, 42, 67, 100, 247, 48, 204, 138, 7, 239, 124, 230, 133, 108, 80, 59, 30, 161, 203, 123, 147, 197, 114, 153, 228, 140, 77, 65, 199, 178 } });
        }
    }
}
