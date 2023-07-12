﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace App.Data.Migrations
{
    public partial class add_col_Reason_AppCompanyPatient : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Reason",
                table: "AppCompanyPatient");

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 152, 252, 62, 186, 116, 36, 214, 238, 83, 13, 14, 42, 18, 180, 137, 145, 139, 7, 98, 90, 237, 130, 201, 109, 40, 246, 120, 48, 24, 162, 133, 98, 110, 207, 56, 167, 170, 103, 92, 43, 243, 102, 203, 15, 210, 119, 21, 186, 178, 0, 100, 211, 207, 231, 129, 230, 228, 144, 253, 207, 191, 11, 91, 199 }, new byte[] { 19, 195, 188, 0, 55, 63, 190, 14, 200, 129, 102, 234, 65, 4, 5, 153, 153, 86, 42, 171, 220, 196, 134, 247, 70, 4, 182, 47, 186, 209, 36, 130, 84, 106, 47, 191, 141, 189, 233, 156, 167, 95, 119, 247, 117, 245, 30, 4, 238, 111, 129, 227, 238, 186, 115, 184, 215, 216, 79, 84, 208, 254, 23, 168, 157, 104, 171, 50, 68, 216, 202, 0, 28, 189, 154, 160, 237, 237, 90, 105, 114, 236, 224, 32, 146, 58, 42, 249, 118, 162, 9, 188, 22, 23, 72, 150, 5, 138, 160, 113, 17, 171, 34, 23, 254, 197, 33, 205, 125, 223, 204, 4, 153, 97, 124, 147, 90, 2, 3, 156, 195, 250, 102, 117, 14, 218, 52, 8 } });
        }
    }
}