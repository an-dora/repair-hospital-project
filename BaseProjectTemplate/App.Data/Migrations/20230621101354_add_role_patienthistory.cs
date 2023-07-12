using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace App.Data.Migrations
{
    public partial class add_role_patienthistory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 92, 240, 53, 103, 59, 150, 39, 25, 196, 15, 68, 53, 239, 195, 94, 78, 153, 234, 226, 5, 192, 31, 240, 215, 95, 76, 185, 251, 144, 231, 73, 74, 144, 202, 185, 152, 180, 162, 129, 225, 249, 108, 116, 24, 177, 118, 20, 143, 167, 169, 101, 90, 136, 89, 253, 38, 115, 143, 43, 20, 155, 70, 220, 6 }, new byte[] { 214, 214, 32, 220, 160, 181, 0, 225, 43, 190, 8, 95, 118, 79, 239, 95, 113, 4, 230, 178, 205, 199, 177, 239, 37, 138, 77, 255, 66, 220, 251, 200, 231, 50, 128, 186, 26, 112, 68, 56, 82, 133, 246, 70, 163, 91, 209, 156, 184, 255, 162, 172, 219, 127, 123, 210, 166, 56, 171, 103, 86, 190, 140, 14, 172, 189, 34, 33, 177, 238, 135, 199, 158, 72, 250, 146, 222, 109, 54, 146, 145, 107, 11, 230, 69, 81, 165, 185, 114, 36, 29, 195, 137, 194, 57, 63, 149, 82, 75, 209, 112, 107, 102, 223, 165, 4, 2, 71, 111, 167, 185, 18, 183, 48, 190, 38, 166, 138, 134, 155, 72, 148, 96, 52, 130, 32, 198, 212 } });

            migrationBuilder.InsertData(
                table: "MstPermission",
                columns: new[] { "Id", "Code", "CreatedDate", "DeletedDate", "Desc", "DisplayOrder", "GroupName", "Table" },
                values: new object[] { 1502, "VIEW_RESULT", new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Xem kết quả khám", null, "Quản lý lịch sử khám", "AppCompanyPatientHistory" });

            migrationBuilder.InsertData(
                table: "MstPermission",
                columns: new[] { "Id", "Code", "CreatedDate", "DeletedDate", "Desc", "DisplayOrder", "GroupName", "Table" },
                values: new object[] { 1501, "INPUT_RESULT", new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Nhập kết quả khám", null, "Quản lý lịch sử khám", "AppCompanyPatientHistory" });

            migrationBuilder.InsertData(
                table: "AppRolePermission",
                columns: new[] { "Id", "AppRoleId", "CreatedBy", "CreatedDate", "DeletedDate", "DisplayOrder", "MstPermissionId", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 27, 1, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1501, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "AppRolePermission",
                columns: new[] { "Id", "AppRoleId", "CreatedBy", "CreatedDate", "DeletedDate", "DisplayOrder", "MstPermissionId", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 28, 1, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1502, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1501);

            migrationBuilder.DeleteData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1502);

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 119, 156, 202, 28, 211, 50, 170, 106, 146, 143, 230, 253, 38, 129, 122, 126, 83, 73, 217, 208, 227, 45, 249, 86, 241, 251, 213, 122, 70, 77, 243, 114, 98, 72, 200, 147, 174, 31, 214, 76, 131, 193, 12, 166, 15, 158, 39, 102, 88, 76, 240, 7, 126, 149, 84, 49, 7, 197, 165, 124, 145, 202, 181, 213 }, new byte[] { 211, 132, 209, 119, 90, 1, 99, 99, 213, 97, 125, 230, 11, 245, 9, 136, 126, 91, 77, 88, 235, 162, 86, 248, 133, 180, 208, 145, 34, 90, 248, 125, 208, 68, 37, 25, 7, 85, 150, 14, 231, 253, 236, 168, 119, 158, 119, 15, 78, 97, 66, 106, 68, 157, 249, 123, 238, 43, 236, 136, 113, 247, 10, 181, 219, 15, 20, 128, 24, 244, 234, 42, 252, 187, 186, 11, 163, 167, 223, 20, 31, 231, 158, 34, 82, 245, 228, 35, 12, 8, 237, 196, 132, 152, 215, 250, 83, 100, 159, 148, 188, 216, 211, 111, 99, 242, 7, 38, 161, 167, 28, 184, 6, 240, 124, 17, 88, 114, 197, 59, 18, 235, 199, 126, 232, 120, 149, 225 } });
        }
    }
}
