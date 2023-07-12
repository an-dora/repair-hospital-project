using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace App.Data.Migrations
{
    public partial class add_role_tbl_Company_CompanyPatient : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 254, 171, 49, 138, 128, 162, 0, 213, 99, 193, 89, 109, 42, 53, 255, 14, 130, 132, 243, 80, 13, 233, 137, 95, 151, 174, 74, 227, 52, 238, 25, 47, 230, 56, 133, 217, 248, 111, 17, 229, 171, 118, 247, 68, 180, 91, 118, 36, 18, 40, 145, 113, 73, 135, 252, 90, 19, 229, 108, 148, 115, 102, 209, 15 }, new byte[] { 133, 140, 200, 75, 181, 147, 49, 36, 209, 208, 28, 160, 237, 59, 116, 241, 197, 127, 157, 155, 106, 60, 104, 63, 77, 83, 208, 37, 55, 171, 245, 214, 4, 84, 94, 185, 114, 236, 9, 92, 224, 197, 213, 154, 42, 117, 194, 199, 217, 176, 134, 42, 182, 46, 209, 148, 108, 24, 76, 246, 238, 173, 202, 212, 170, 142, 201, 239, 67, 179, 75, 31, 164, 74, 126, 179, 97, 148, 110, 7, 54, 35, 106, 134, 129, 230, 83, 195, 157, 47, 28, 68, 8, 222, 216, 2, 25, 126, 146, 188, 87, 243, 57, 230, 70, 200, 169, 62, 224, 121, 59, 39, 65, 183, 150, 242, 140, 111, 108, 4, 225, 26, 156, 242, 193, 209, 60, 94 } });

            migrationBuilder.InsertData(
                table: "MstPermission",
                columns: new[] { "Id", "Code", "CreatedDate", "DeletedDate", "Desc", "DisplayOrder", "GroupName", "Table" },
                values: new object[,]
                {
                    { 1303, "CREATE", new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Thêm công ty", null, "Quản lý công ty", "AppCompany" },
                    { 1305, "HIDE", new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Ẩn công ty", null, "Quản lý công ty", "AppCompany" },
                    { 1306, "UNHIDE", new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Hiện công ty", null, "Quản lý công ty", "AppCompany" },
                    { 1304, "UPDATE", new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Cập nhật công ty", null, "Quản lý công ty", "AppCompany" },
                    { 1301, "VIEW_LIST", new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Xem danh sách công ty", null, "Quản lý công ty", "AppCompany" },
                    { 1403, "CREATE", new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Thêm bệnh nhân", null, "Quản lý bệnh nhân", "AppCompanyPatient" },
                    { 1405, "HIDE", new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Ẩn bệnh nhân", null, "Quản lý bệnh nhân", "AppCompanyPatient" },
                    { 1406, "UNHIDE", new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Hiện bệnh nhân", null, "Quản lý bệnh nhân", "AppCompanyPatient" },
                    { 1404, "UPDATE", new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Cập nhật bệnh nhân", null, "Quản lý bệnh nhân", "AppCompanyPatient" },
                    { 1401, "VIEW_LIST", new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Xem danh sách bệnh nhân", null, "Quản lý bệnh nhân", "AppCompanyPatient" },
                    { 1407, "IMPORT_EXCEL", new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Import dữ liệu bệnh nhân", null, "Quản lý bệnh nhân", "AppCompanyPatient" }
                });

            migrationBuilder.InsertData(
                table: "AppRolePermission",
                columns: new[] { "Id", "AppRoleId", "CreatedBy", "CreatedDate", "DeletedDate", "DisplayOrder", "MstPermissionId", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 16, 1, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1303, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 18, 1, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1305, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 19, 1, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1306, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 17, 1, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1304, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 15, 1, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1301, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 21, 1, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1403, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 23, 1, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1405, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 24, 1, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1406, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 22, 1, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1404, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 20, 1, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1401, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 25, 1, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1407, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1301);

            migrationBuilder.DeleteData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1303);

            migrationBuilder.DeleteData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1304);

            migrationBuilder.DeleteData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1305);

            migrationBuilder.DeleteData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1306);

            migrationBuilder.DeleteData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1401);

            migrationBuilder.DeleteData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1403);

            migrationBuilder.DeleteData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1404);

            migrationBuilder.DeleteData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1405);

            migrationBuilder.DeleteData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1406);

            migrationBuilder.DeleteData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1407);

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 6, 16, 62, 178, 200, 101, 217, 38, 223, 143, 102, 171, 133, 152, 213, 102, 214, 50, 24, 206, 96, 253, 142, 3, 23, 168, 140, 109, 143, 126, 236, 65, 47, 233, 47, 106, 79, 103, 7, 230, 12, 128, 174, 222, 208, 115, 176, 233, 15, 113, 195, 14, 166, 124, 219, 189, 160, 236, 164, 45, 130, 193, 186, 166 }, new byte[] { 170, 31, 26, 219, 37, 238, 255, 208, 7, 100, 44, 189, 80, 154, 25, 220, 95, 45, 182, 135, 71, 177, 42, 169, 227, 212, 233, 148, 203, 158, 52, 154, 60, 15, 16, 7, 147, 179, 214, 86, 232, 98, 102, 218, 65, 208, 57, 118, 161, 233, 213, 233, 1, 216, 193, 123, 47, 43, 15, 55, 240, 25, 14, 192, 15, 112, 130, 141, 194, 73, 218, 15, 82, 219, 225, 254, 91, 253, 98, 14, 202, 253, 215, 219, 14, 53, 132, 13, 118, 204, 110, 186, 41, 227, 180, 145, 168, 235, 5, 230, 212, 191, 30, 0, 51, 168, 64, 114, 140, 53, 125, 86, 215, 161, 238, 129, 230, 161, 187, 95, 10, 126, 120, 58, 242, 116, 100, 98 } });
        }
    }
}
