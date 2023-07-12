using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace App.Data.Migrations
{
    public partial class addpermisstion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "MstPermission",
                columns: new[] { "Id", "Code", "CreatedDate", "DeletedDate", "Desc", "DisplayOrder", "GroupName", "Table" },
                values: new object[] { 1408, "PRINT_HEALTH_CERT", new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "In phiếu khám sức khỏe", null, "Quản lý bệnh nhân", "AppCompanyPatient" });

            migrationBuilder.InsertData(
                table: "AppRolePermission",
                columns: new[] { "Id", "AppRoleId", "CreatedBy", "CreatedDate", "DeletedDate", "DisplayOrder", "MstPermissionId", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 26, 1, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1408, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1408);
        }
    }
}
