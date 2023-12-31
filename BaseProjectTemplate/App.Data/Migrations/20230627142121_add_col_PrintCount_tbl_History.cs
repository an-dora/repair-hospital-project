﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace App.Data.Migrations
{
    public partial class add_col_PrintCount_tbl_History : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PrintCount",
                table: "AppCompanyPatientHistory",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 91, 107, 81, 237, 172, 24, 20, 36, 154, 90, 199, 15, 228, 83, 29, 167, 49, 155, 234, 110, 156, 16, 186, 245, 155, 180, 42, 237, 46, 11, 196, 149, 249, 1, 30, 247, 162, 242, 55, 133, 243, 123, 161, 63, 161, 118, 101, 251, 82, 7, 164, 170, 239, 60, 24, 181, 7, 252, 93, 12, 138, 252, 17, 26 }, new byte[] { 71, 3, 132, 96, 70, 156, 194, 105, 246, 229, 65, 201, 178, 25, 215, 3, 11, 191, 151, 144, 201, 241, 23, 56, 93, 181, 46, 95, 215, 28, 100, 194, 214, 145, 203, 118, 42, 99, 250, 80, 69, 91, 218, 26, 111, 95, 232, 142, 199, 49, 243, 188, 39, 224, 45, 34, 231, 16, 132, 21, 9, 245, 61, 185, 249, 143, 185, 146, 224, 108, 227, 100, 71, 3, 202, 190, 190, 51, 149, 220, 37, 78, 242, 14, 0, 206, 250, 123, 208, 53, 143, 170, 139, 236, 27, 60, 96, 167, 205, 198, 121, 140, 154, 1, 129, 51, 97, 52, 236, 250, 120, 200, 26, 85, 253, 34, 66, 130, 25, 77, 218, 65, 191, 204, 60, 107, 56, 246 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PrintCount",
                table: "AppCompanyPatientHistory");

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 225, 179, 35, 108, 189, 236, 14, 46, 215, 201, 64, 182, 201, 129, 168, 131, 95, 57, 92, 254, 68, 238, 21, 220, 163, 50, 202, 60, 115, 153, 21, 22, 95, 219, 196, 33, 216, 154, 67, 130, 182, 111, 157, 75, 154, 192, 162, 124, 172, 122, 250, 145, 8, 229, 159, 22, 6, 30, 255, 135, 27, 228, 245, 108 }, new byte[] { 88, 229, 199, 160, 78, 210, 228, 203, 124, 120, 197, 56, 253, 103, 15, 168, 81, 202, 221, 245, 136, 23, 20, 226, 32, 191, 174, 118, 221, 199, 33, 135, 43, 50, 241, 98, 255, 245, 128, 1, 65, 236, 189, 103, 49, 76, 74, 126, 246, 113, 111, 0, 17, 233, 129, 236, 216, 39, 157, 13, 125, 209, 67, 95, 154, 70, 179, 121, 179, 200, 253, 131, 150, 117, 10, 188, 20, 244, 144, 171, 114, 149, 62, 17, 118, 160, 91, 85, 196, 183, 215, 124, 167, 196, 116, 24, 25, 193, 76, 12, 179, 168, 191, 173, 28, 206, 139, 186, 196, 21, 89, 97, 240, 59, 152, 178, 41, 64, 222, 45, 18, 69, 0, 50, 114, 103, 231, 203 } });
        }
    }
}
