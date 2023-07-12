using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace App.Data.Migrations
{
    public partial class deletedataAppRolePermission : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 225, 179, 35, 108, 189, 236, 14, 46, 215, 201, 64, 182, 201, 129, 168, 131, 95, 57, 92, 254, 68, 238, 21, 220, 163, 50, 202, 60, 115, 153, 21, 22, 95, 219, 196, 33, 216, 154, 67, 130, 182, 111, 157, 75, 154, 192, 162, 124, 172, 122, 250, 145, 8, 229, 159, 22, 6, 30, 255, 135, 27, 228, 245, 108 }, new byte[] { 88, 229, 199, 160, 78, 210, 228, 203, 124, 120, 197, 56, 253, 103, 15, 168, 81, 202, 221, 245, 136, 23, 20, 226, 32, 191, 174, 118, 221, 199, 33, 135, 43, 50, 241, 98, 255, 245, 128, 1, 65, 236, 189, 103, 49, 76, 74, 126, 246, 113, 111, 0, 17, 233, 129, 236, 216, 39, 157, 13, 125, 209, 67, 95, 154, 70, 179, 121, 179, 200, 253, 131, 150, 117, 10, 188, 20, 244, 144, 171, 114, 149, 62, 17, 118, 160, 91, 85, 196, 183, 215, 124, 167, 196, 116, 24, 25, 193, 76, 12, 179, 168, 191, 173, 28, 206, 139, 186, 196, 21, 89, 97, 240, 59, 152, 178, 41, 64, 222, 45, 18, 69, 0, 50, 114, 103, 231, 203 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AppRolePermission",
                columns: new[] { "Id", "AppRoleId", "CreatedBy", "CreatedDate", "DeletedDate", "DisplayOrder", "MstPermissionId", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 15, 1, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1301, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 29, 1, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1502, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 28, 1, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1501, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 27, 1, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1409, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 26, 1, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1408, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 25, 1, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1407, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 24, 1, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1406, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 30, 1, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1503, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 23, 1, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1405, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 21, 1, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1403, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 20, 1, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1401, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 19, 1, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1306, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 18, 1, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1305, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 17, 1, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1304, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 16, 1, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1303, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 22, 1, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1404, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 8, 77, 111, 42, 105, 248, 132, 249, 6, 114, 149, 215, 210, 19, 80, 137, 90, 207, 36, 76, 62, 109, 149, 14, 144, 173, 65, 81, 224, 207, 157, 15, 56, 87, 82, 220, 218, 29, 163, 181, 4, 3, 196, 199, 157, 96, 41, 175, 231, 173, 38, 196, 29, 173, 227, 169, 228, 85, 147, 149, 134, 196, 213, 116 }, new byte[] { 44, 244, 51, 76, 132, 158, 213, 70, 111, 138, 231, 56, 37, 232, 234, 236, 207, 121, 68, 123, 204, 13, 121, 177, 18, 169, 220, 60, 167, 134, 31, 141, 220, 25, 251, 226, 69, 48, 148, 120, 7, 121, 222, 223, 127, 42, 159, 90, 12, 148, 91, 5, 76, 196, 15, 150, 88, 106, 226, 90, 243, 153, 175, 202, 235, 12, 4, 100, 26, 242, 169, 207, 204, 74, 221, 153, 140, 44, 150, 112, 243, 25, 156, 191, 39, 10, 161, 86, 230, 34, 38, 71, 87, 94, 228, 206, 215, 116, 47, 191, 27, 36, 93, 172, 53, 246, 18, 218, 204, 158, 123, 99, 106, 52, 231, 71, 150, 125, 7, 24, 212, 239, 1, 76, 226, 1, 25, 184 } });
        }
    }
}
