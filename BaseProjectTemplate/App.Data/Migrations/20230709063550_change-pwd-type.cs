using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace App.Data.Migrations
{
    public partial class changepwdtype : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "PasswordSalt",
                table: "AppUser");

            migrationBuilder.AlterColumn<string>(
                name: "PasswordHash",
                table: "AppUser",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "varbinary(200)",
                oldMaxLength: 200,
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<byte[]>(
                name: "PasswordHash",
                table: "AppUser",
                type: "varbinary(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "PasswordSalt",
                table: "AppUser",
                type: "varbinary(200)",
                maxLength: 200,
                nullable: true);

            migrationBuilder.InsertData(
                table: "AppUser",
                columns: new[] { "Id", "Address", "AppRoleId", "Avatar", "BlockedBy", "BlockedTo", "CreatedBy", "CreatedDate", "DeletedDate", "DisplayOrder", "Email", "FullName", "PasswordHash", "PasswordSalt", "PhoneNumber1", "PhoneNumber2", "UpdatedBy", "UpdatedDate", "Username" },
                values: new object[] { 1, "Thành phố Hồ Chí Minh", 1, null, null, null, -1, new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "admin_test@gmail.com", "Obama", new byte[] { 91, 107, 81, 237, 172, 24, 20, 36, 154, 90, 199, 15, 228, 83, 29, 167, 49, 155, 234, 110, 156, 16, 186, 245, 155, 180, 42, 237, 46, 11, 196, 149, 249, 1, 30, 247, 162, 242, 55, 133, 243, 123, 161, 63, 161, 118, 101, 251, 82, 7, 164, 170, 239, 60, 24, 181, 7, 252, 93, 12, 138, 252, 17, 26 }, new byte[] { 71, 3, 132, 96, 70, 156, 194, 105, 246, 229, 65, 201, 178, 25, 215, 3, 11, 191, 151, 144, 201, 241, 23, 56, 93, 181, 46, 95, 215, 28, 100, 194, 214, 145, 203, 118, 42, 99, 250, 80, 69, 91, 218, 26, 111, 95, 232, 142, 199, 49, 243, 188, 39, 224, 45, 34, 231, 16, 132, 21, 9, 245, 61, 185, 249, 143, 185, 146, 224, 108, 227, 100, 71, 3, 202, 190, 190, 51, 149, 220, 37, 78, 242, 14, 0, 206, 250, 123, 208, 53, 143, 170, 139, 236, 27, 60, 96, 167, 205, 198, 121, 140, 154, 1, 129, 51, 97, 52, 236, 250, 120, 200, 26, 85, 253, 34, 66, 130, 25, 77, 218, 65, 191, 204, 60, 107, 56, 246 }, "0928666158", "0928666156", -1, new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin" });
        }
    }
}
