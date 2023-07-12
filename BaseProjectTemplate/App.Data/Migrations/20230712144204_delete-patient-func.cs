using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace App.Data.Migrations
{
    public partial class deletepatientfunc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {


            migrationBuilder.InsertData(
                table: "MstPermission",
                columns: new[] { "Id", "Code", "CreatedDate", "DeletedDate", "Desc", "DisplayOrder", "GroupName", "Table" },
                values: new object[] { 1410, "DELETE", new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Xóa dữ liệu bệnh nhân", null, "Quản lý bệnh nhân", "AppCompanyPatient" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1410);
        }
    }
}
