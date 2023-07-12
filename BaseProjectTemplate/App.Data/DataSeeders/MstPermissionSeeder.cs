using App.Data.Entities;
using App.Share.Consts;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Data.DataSeeders
{
	public static class MstPermissionSeeder
	{
		public static void SeedData(this EntityTypeBuilder<MstPermission> builder)
		{
			var now = new DateTime(year: 2021, month: 11, day: 10);
			var groupName = "";

			#region Data liên quan đến bảng Role
			// Permission liên quan đến bảng AppRole
			groupName = "Quản lý phân quyền";
			builder.HasData(
				new MstPermission
				{
					Id = AuthConst.AppRole.CREATE,
					Code = "CREATE",
					Table = DB.AppRole.TABLE_NAME,
					GroupName = groupName,
					Desc = "Thêm quyền",
					CreatedDate = now
				},
				new MstPermission
				{
					Id = AuthConst.AppRole.DELETE,
					Code = "DELETE",
					Table = DB.AppRole.TABLE_NAME,
					GroupName = groupName,
					Desc = "Xóa quyền",
					CreatedDate = now
				},
				new MstPermission
				{
					Id = AuthConst.AppRole.UPDATE,
					Code = "UPDATE",
					Table = DB.AppRole.TABLE_NAME,
					GroupName = groupName,
					Desc = "Sửa quyền",
					CreatedDate = now
				},
				new MstPermission
				{
					Id = AuthConst.AppRole.VIEW_DETAIL,
					Code = "VIEW_DETAIL",
					Table = DB.AppRole.TABLE_NAME,
					GroupName = groupName,
					Desc = "Xem chi tiết quyền",
					CreatedDate = now
				},
				new MstPermission
				{
					Id = AuthConst.AppRole.VIEW_LIST,
					Code = "VIEW_LIST",
					Table = DB.AppRole.TABLE_NAME,
					GroupName = groupName,
					Desc = "Xem danh sách quyền",
					CreatedDate = now
				}
			);
			#endregion

			#region Data liên quản bảng User
			// Permission liên quan đến bảng AppUser
			groupName = "Quản lý người dùng";
			builder.HasData(
				new MstPermission
				{
					Id = AuthConst.AppUser.BLOCK,
					Code = "BLOCK",
					Table = DB.AppUser.TABLE_NAME,
					GroupName = groupName,
					Desc = "Khóa người dùng",
					CreatedDate = now
				},
				new MstPermission
				{
					Id = AuthConst.AppUser.CREATE,
					Code = "CREATE",
					Table = DB.AppUser.TABLE_NAME,
					GroupName = groupName,
					Desc = "Thêm người dùng",
					CreatedDate = now
				},
				new MstPermission
				{
					Id = AuthConst.AppUser.DELETE,
					Code = "DELETE",
					Table = DB.AppUser.TABLE_NAME,
					GroupName = groupName,
					Desc = "Xóa người dùng",
					CreatedDate = now
				},
				new MstPermission
				{
					Id = AuthConst.AppUser.UNBLOCK,
					Code = "UNBLOCK",
					Table = DB.AppUser.TABLE_NAME,
					GroupName = groupName,
					Desc = "Mở khóa người dùng",
					CreatedDate = now
				},
				new MstPermission
				{
					Id = AuthConst.AppUser.UPDATE,
					Code = "UPDATE",
					Table = DB.AppUser.TABLE_NAME,
					GroupName = groupName,
					Desc = "Cập nhật người dùng",
					CreatedDate = now
				},
				new MstPermission
				{
					Id = AuthConst.AppUser.UPDATE_PWD,
					Code = "UPDATE_PWD",
					Table = DB.AppUser.TABLE_NAME,
					GroupName = groupName,
					Desc = "Đổi mật khẩu",
					CreatedDate = now
				},
				new MstPermission
				{
					Id = AuthConst.AppUser.VIEW_DETAIL,
					Code = "VIEW_DETAIL",
					Table = DB.AppUser.TABLE_NAME,
					GroupName = groupName,
					Desc = "Xem chi tiết người dùng",
					CreatedDate = now
				},
				new MstPermission
				{
					Id = AuthConst.AppUser.VIEW_LIST,
					Code = "VIEW_LIST",
					Table = DB.AppUser.TABLE_NAME,
					GroupName = groupName,
					Desc = "Xem danh sách người dùng",
					CreatedDate = now
				}
			);
			#endregion

			#region Data liên quan đến quản lý file
			// Permission liên quan đến quản lý file
			groupName = "Quản lý file";
			builder.HasData(
				new MstPermission
				{
					Id = AuthConst.FileManager.MANAGE_ALL_USER_FILES,
					Code = "MANAGER",
					Table = "FileManager",
					GroupName = groupName,
					Desc = "Quản lý file hệ thống",
					CreatedDate = now
				}
			);
			#endregion

			#region Data liên quản bảng AppCompany
			// Permission liên quan đến bảng AppCompany
			groupName = "Quản lý công ty";
			builder.HasData(
				new MstPermission
				{
					Id = AuthConst.AppCompany.CREATE,
					Code = "CREATE",
					Table = DB.AppCompany.TABLE_NAME,
					GroupName = groupName,
					Desc = "Thêm công ty",
					CreatedDate = now
				},
				new MstPermission
				{
					Id = AuthConst.AppCompany.HIDE,
					Code = "HIDE",
					Table = DB.AppCompany.TABLE_NAME,
					GroupName = groupName,
					Desc = "Ẩn công ty",
					CreatedDate = now
				},
				new MstPermission
				{
					Id = AuthConst.AppCompany.UNHIDE,
					Code = "UNHIDE",
					Table = DB.AppCompany.TABLE_NAME,
					GroupName = groupName,
					Desc = "Hiện công ty",
					CreatedDate = now
				},
				new MstPermission
				{
					Id = AuthConst.AppCompany.UPDATE,
					Code = "UPDATE",
					Table = DB.AppCompany.TABLE_NAME,
					GroupName = groupName,
					Desc = "Cập nhật công ty",
					CreatedDate = now
				},
				new MstPermission
				{
					Id = AuthConst.AppCompany.VIEW_LIST,
					Code = "VIEW_LIST",
					Table = DB.AppCompany.TABLE_NAME,
					GroupName = groupName,
					Desc = "Xem danh sách công ty",
					CreatedDate = now
				}
			);
			#endregion

			#region Data liên quản bảng AppCompanyPatient
			// Permission liên quan đến bảng AppCompanyPatient
			groupName = "Quản lý bệnh nhân";
			builder.HasData(
				new MstPermission
				{
					Id = AuthConst.AppCompanyPatient.CREATE,
					Code = "CREATE",
					Table = DB.AppCompanyPatient.TABLE_NAME,
					GroupName = groupName,
					Desc = "Thêm bệnh nhân",
					CreatedDate = now
				},
				new MstPermission
				{
					Id = AuthConst.AppCompanyPatient.HIDE,
					Code = "HIDE",
					Table = DB.AppCompanyPatient.TABLE_NAME,
					GroupName = groupName,
					Desc = "Ẩn bệnh nhân",
					CreatedDate = now
				},
				new MstPermission
				{
					Id = AuthConst.AppCompanyPatient.UNHIDE,
					Code = "UNHIDE",
					Table = DB.AppCompanyPatient.TABLE_NAME,
					GroupName = groupName,
					Desc = "Hiện bệnh nhân",
					CreatedDate = now
				},
				new MstPermission
				{
					Id = AuthConst.AppCompanyPatient.UPDATE,
					Code = "UPDATE",
					Table = DB.AppCompanyPatient.TABLE_NAME,
					GroupName = groupName,
					Desc = "Cập nhật bệnh nhân",
					CreatedDate = now
				},
				new MstPermission
				{
					Id = AuthConst.AppCompanyPatient.VIEW_LIST,
					Code = "VIEW_LIST",
					Table = DB.AppCompanyPatient.TABLE_NAME,
					GroupName = groupName,
					Desc = "Xem danh sách bệnh nhân",
					CreatedDate = now
				},
				new MstPermission
				{
					Id = AuthConst.AppCompanyPatient.IMPORT_EXCEL,
					Code = "IMPORT_EXCEL",
					Table = DB.AppCompanyPatient.TABLE_NAME,
					GroupName = groupName,
					Desc = "Import dữ liệu bệnh nhân",
					CreatedDate = now
				},
				new MstPermission
				{
					Id = AuthConst.AppCompanyPatient.PRINT_HEALTH_CERT,
					Code = "PRINT_HEALTH_CERT",
					Table = DB.AppCompanyPatient.TABLE_NAME,
					GroupName = groupName,
					Desc = "In phiếu khám sức khỏe",
					CreatedDate = now
				},
				new MstPermission
				{
					Id = AuthConst.AppCompanyPatient.EXPORT_EXCEL,
					Code = "EXPORT_EXCEL",
					Table = DB.AppCompanyPatient.TABLE_NAME,
					GroupName = groupName,
					Desc = "Export dữ liệu bệnh nhân",
					CreatedDate = now

				},
				new MstPermission
				{
					Id = AuthConst.AppCompanyPatient.DELETE,
					Code = "DELETE",
					Table = DB.AppCompanyPatient.TABLE_NAME,
					GroupName = groupName,
					Desc = "Xóa dữ liệu bệnh nhân",
					CreatedDate = now
				}
			);
			#endregion

			#region Data liên quản bảng AppCompanyPatientHistory
			// Permission liên quan đến bảng AppCompanyPatientHistory
			groupName = "Quản lý lịch sử khám";
			builder.HasData(
				new MstPermission
				{
					Id = AuthConst.AppCompanyPatientHistory.INPUT_RESULT,
					Code = "INPUT_RESULT",
					Table = DB.AppCompanyPatientHistory.TABLE_NAME,
					GroupName = groupName,
					Desc = "Nhập kết quả khám",
					CreatedDate = now
				},
				new MstPermission
				{
					Id = AuthConst.AppCompanyPatientHistory.VIEW_RESULT,
					Code = "VIEW_RESULT",
					Table = DB.AppCompanyPatientHistory.TABLE_NAME,
					GroupName = groupName,
					Desc = "Xem kết quả khám",
					CreatedDate = now
				},
				new MstPermission
				{
					Id = AuthConst.AppCompanyPatientHistory.UPDATE_RESULT,
					Code = "UPDATE_RESULT",
					Table = DB.AppCompanyPatientHistory.TABLE_NAME,
					GroupName = groupName,
					Desc = "Sửa kết quả khám",
					CreatedDate = now
				}
			);
			#endregion
		}
	}
}
