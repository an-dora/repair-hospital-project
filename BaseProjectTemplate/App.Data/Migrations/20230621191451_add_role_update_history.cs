using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace App.Data.Migrations
{
    public partial class add_role_update_history : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 79, 124, 125, 47, 14, 29, 27, 27, 158, 117, 192, 90, 123, 64, 80, 60, 34, 136, 43, 2, 171, 78, 224, 101, 50, 176, 167, 58, 118, 57, 43, 173, 95, 147, 101, 27, 135, 184, 233, 18, 192, 178, 162, 106, 135, 26, 91, 24, 176, 99, 226, 97, 143, 184, 121, 1, 63, 71, 234, 146, 37, 216, 133, 198 }, new byte[] { 88, 121, 157, 95, 73, 100, 174, 35, 191, 29, 184, 102, 199, 142, 198, 147, 55, 42, 98, 139, 25, 3, 63, 40, 25, 17, 130, 16, 178, 136, 216, 224, 168, 234, 43, 245, 70, 183, 120, 77, 44, 199, 147, 45, 174, 159, 123, 47, 116, 116, 75, 189, 113, 60, 35, 196, 55, 69, 237, 100, 238, 164, 225, 35, 108, 48, 38, 159, 99, 95, 141, 75, 71, 83, 100, 166, 92, 248, 33, 169, 156, 150, 47, 10, 121, 186, 43, 177, 187, 130, 16, 245, 8, 205, 211, 86, 185, 108, 106, 202, 90, 170, 130, 84, 210, 95, 180, 38, 21, 173, 109, 121, 73, 197, 17, 76, 194, 161, 170, 246, 39, 19, 60, 224, 15, 17, 23, 166 } });

            migrationBuilder.InsertData(
                table: "MstPermission",
                columns: new[] { "Id", "Code", "CreatedDate", "DeletedDate", "Desc", "DisplayOrder", "GroupName", "Table" },
                values: new object[] { 1503, "UPDATE_RESULT", new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sửa kết quả khám", null, "Quản lý lịch sử khám", "AppCompanyPatientHistory" });

            migrationBuilder.InsertData(
                table: "AppRolePermission",
                columns: new[] { "Id", "AppRoleId", "CreatedBy", "CreatedDate", "DeletedDate", "DisplayOrder", "MstPermissionId", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 29, 1, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1503, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1503);

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 92, 240, 53, 103, 59, 150, 39, 25, 196, 15, 68, 53, 239, 195, 94, 78, 153, 234, 226, 5, 192, 31, 240, 215, 95, 76, 185, 251, 144, 231, 73, 74, 144, 202, 185, 152, 180, 162, 129, 225, 249, 108, 116, 24, 177, 118, 20, 143, 167, 169, 101, 90, 136, 89, 253, 38, 115, 143, 43, 20, 155, 70, 220, 6 }, new byte[] { 214, 214, 32, 220, 160, 181, 0, 225, 43, 190, 8, 95, 118, 79, 239, 95, 113, 4, 230, 178, 205, 199, 177, 239, 37, 138, 77, 255, 66, 220, 251, 200, 231, 50, 128, 186, 26, 112, 68, 56, 82, 133, 246, 70, 163, 91, 209, 156, 184, 255, 162, 172, 219, 127, 123, 210, 166, 56, 171, 103, 86, 190, 140, 14, 172, 189, 34, 33, 177, 238, 135, 199, 158, 72, 250, 146, 222, 109, 54, 146, 145, 107, 11, 230, 69, 81, 165, 185, 114, 36, 29, 195, 137, 194, 57, 63, 149, 82, 75, 209, 112, 107, 102, 223, 165, 4, 2, 71, 111, 167, 185, 18, 183, 48, 190, 38, 166, 138, 134, 155, 72, 148, 96, 52, 130, 32, 198, 212 } });
        }
    }
}
