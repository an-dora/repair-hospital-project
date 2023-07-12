using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace App.Data.Migrations
{
    public partial class add_role_exportExcel_patient : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 28,
                column: "MstPermissionId",
                value: 1501);

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 29,
                column: "MstPermissionId",
                value: 1502);

            migrationBuilder.InsertData(
                table: "AppRolePermission",
                columns: new[] { "Id", "AppRoleId", "CreatedBy", "CreatedDate", "DeletedDate", "DisplayOrder", "MstPermissionId", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 30, 1, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1503, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 8, 77, 111, 42, 105, 248, 132, 249, 6, 114, 149, 215, 210, 19, 80, 137, 90, 207, 36, 76, 62, 109, 149, 14, 144, 173, 65, 81, 224, 207, 157, 15, 56, 87, 82, 220, 218, 29, 163, 181, 4, 3, 196, 199, 157, 96, 41, 175, 231, 173, 38, 196, 29, 173, 227, 169, 228, 85, 147, 149, 134, 196, 213, 116 }, new byte[] { 44, 244, 51, 76, 132, 158, 213, 70, 111, 138, 231, 56, 37, 232, 234, 236, 207, 121, 68, 123, 204, 13, 121, 177, 18, 169, 220, 60, 167, 134, 31, 141, 220, 25, 251, 226, 69, 48, 148, 120, 7, 121, 222, 223, 127, 42, 159, 90, 12, 148, 91, 5, 76, 196, 15, 150, 88, 106, 226, 90, 243, 153, 175, 202, 235, 12, 4, 100, 26, 242, 169, 207, 204, 74, 221, 153, 140, 44, 150, 112, 243, 25, 156, 191, 39, 10, 161, 86, 230, 34, 38, 71, 87, 94, 228, 206, 215, 116, 47, 191, 27, 36, 93, 172, 53, 246, 18, 218, 204, 158, 123, 99, 106, 52, 231, 71, 150, 125, 7, 24, 212, 239, 1, 76, 226, 1, 25, 184 } });

            migrationBuilder.InsertData(
                table: "MstPermission",
                columns: new[] { "Id", "Code", "CreatedDate", "DeletedDate", "Desc", "DisplayOrder", "GroupName", "Table" },
                values: new object[] { 1409, "EXPORT_EXCEL", new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Export dữ liệu bệnh nhân", null, "Quản lý bệnh nhân", "AppCompanyPatient" });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 27,
                column: "MstPermissionId",
                value: 1409);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1409);

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 27,
                column: "MstPermissionId",
                value: 1501);

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 28,
                column: "MstPermissionId",
                value: 1502);

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 29,
                column: "MstPermissionId",
                value: 1503);

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 79, 124, 125, 47, 14, 29, 27, 27, 158, 117, 192, 90, 123, 64, 80, 60, 34, 136, 43, 2, 171, 78, 224, 101, 50, 176, 167, 58, 118, 57, 43, 173, 95, 147, 101, 27, 135, 184, 233, 18, 192, 178, 162, 106, 135, 26, 91, 24, 176, 99, 226, 97, 143, 184, 121, 1, 63, 71, 234, 146, 37, 216, 133, 198 }, new byte[] { 88, 121, 157, 95, 73, 100, 174, 35, 191, 29, 184, 102, 199, 142, 198, 147, 55, 42, 98, 139, 25, 3, 63, 40, 25, 17, 130, 16, 178, 136, 216, 224, 168, 234, 43, 245, 70, 183, 120, 77, 44, 199, 147, 45, 174, 159, 123, 47, 116, 116, 75, 189, 113, 60, 35, 196, 55, 69, 237, 100, 238, 164, 225, 35, 108, 48, 38, 159, 99, 95, 141, 75, 71, 83, 100, 166, 92, 248, 33, 169, 156, 150, 47, 10, 121, 186, 43, 177, 187, 130, 16, 245, 8, 205, 211, 86, 185, 108, 106, 202, 90, 170, 130, 84, 210, 95, 180, 38, 21, 173, 109, 121, 73, 197, 17, 76, 194, 161, 170, 246, 39, 19, 60, 224, 15, 17, 23, 166 } });
        }
    }
}
