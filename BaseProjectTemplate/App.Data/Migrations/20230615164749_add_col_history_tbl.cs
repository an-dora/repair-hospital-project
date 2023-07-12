using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace App.Data.Migrations
{
    public partial class add_col_history_tbl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Reason",
                table: "AppCompanyPatient");

            migrationBuilder.AddColumn<bool>(
                name: "IsDone",
                table: "AppCompanyPatientHistory",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Reason",
                table: "AppCompanyPatientHistory",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 6, 16, 62, 178, 200, 101, 217, 38, 223, 143, 102, 171, 133, 152, 213, 102, 214, 50, 24, 206, 96, 253, 142, 3, 23, 168, 140, 109, 143, 126, 236, 65, 47, 233, 47, 106, 79, 103, 7, 230, 12, 128, 174, 222, 208, 115, 176, 233, 15, 113, 195, 14, 166, 124, 219, 189, 160, 236, 164, 45, 130, 193, 186, 166 }, new byte[] { 170, 31, 26, 219, 37, 238, 255, 208, 7, 100, 44, 189, 80, 154, 25, 220, 95, 45, 182, 135, 71, 177, 42, 169, 227, 212, 233, 148, 203, 158, 52, 154, 60, 15, 16, 7, 147, 179, 214, 86, 232, 98, 102, 218, 65, 208, 57, 118, 161, 233, 213, 233, 1, 216, 193, 123, 47, 43, 15, 55, 240, 25, 14, 192, 15, 112, 130, 141, 194, 73, 218, 15, 82, 219, 225, 254, 91, 253, 98, 14, 202, 253, 215, 219, 14, 53, 132, 13, 118, 204, 110, 186, 41, 227, 180, 145, 168, 235, 5, 230, 212, 191, 30, 0, 51, 168, 64, 114, 140, 53, 125, 86, 215, 161, 238, 129, 230, 161, 187, 95, 10, 126, 120, 58, 242, 116, 100, 98 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDone",
                table: "AppCompanyPatientHistory");

            migrationBuilder.DropColumn(
                name: "Reason",
                table: "AppCompanyPatientHistory");

            migrationBuilder.AddColumn<string>(
                name: "Reason",
                table: "AppCompanyPatient",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 94, 123, 34, 250, 163, 12, 131, 129, 31, 99, 92, 1, 218, 45, 45, 173, 150, 231, 173, 234, 97, 220, 102, 20, 92, 229, 171, 123, 136, 117, 176, 150, 37, 253, 175, 163, 125, 42, 104, 196, 29, 38, 26, 112, 215, 180, 167, 198, 226, 92, 176, 166, 130, 191, 76, 130, 103, 209, 48, 35, 88, 211, 176, 169 }, new byte[] { 42, 249, 130, 145, 72, 125, 22, 215, 13, 56, 190, 112, 123, 127, 96, 69, 210, 185, 145, 218, 114, 75, 120, 21, 154, 211, 114, 34, 250, 206, 177, 143, 209, 111, 71, 243, 109, 44, 147, 137, 74, 104, 157, 216, 131, 130, 142, 70, 84, 28, 249, 180, 5, 99, 228, 229, 174, 233, 200, 188, 159, 220, 151, 156, 183, 70, 7, 165, 3, 203, 204, 135, 45, 101, 110, 80, 109, 41, 57, 3, 175, 59, 2, 96, 95, 13, 155, 24, 16, 3, 251, 7, 179, 208, 150, 248, 85, 25, 58, 181, 246, 55, 62, 26, 28, 98, 49, 243, 16, 96, 128, 75, 174, 105, 58, 147, 31, 0, 81, 76, 97, 180, 61, 123, 219, 42, 81, 77 } });
        }
    }
}
