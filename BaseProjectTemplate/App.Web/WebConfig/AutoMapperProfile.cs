using App.Data.Entities;
using App.Web.ViewModels.Account;
using App.Web.ViewModels.Company;
using App.Web.ViewModels.CompanyPatient;
using App.Web.ViewModels.PatientHistory;
using App.Web.ViewModels.Role;
using App.Web.ViewModels.User;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.Web.WebConfig
{
	public class AutoMapperProfile : Profile
	{
		public AutoMapperProfile()
		{
			// Map dữ liệu từ kiểu UserAddOrEditVM sang AppUser
			CreateMap<UserAddOrEditVM, AppUser>();

			// Map dữ liệu từ kiểu AppUser sang UserAddOrEditVM
			CreateMap<AppUser, UserAddOrEditVM>();

			CreateMap<DepartmentVM, AppCompanyDepartment>().ReverseMap();

			CreateMap<AppCompany, CompanyAddOrEditVM>().ReverseMap();

			CreateMap<AppCompanyPatient, PatientAddOrEditVM>().ReverseMap();

			CreateMap<AppCompanyPatientHistory, PatientHistoryVM>().ReverseMap();
		}

		public static MapperConfiguration RoleIndexConf = new(mapper =>
		{
			// Map dữ liệu từ kiểu AppRole sang RoleListItemVM
			mapper.CreateMap<AppRole, RoleListItemVM>();
		});

		// Cấu hình mapping cho UserController, action Index
		public static MapperConfiguration UserIndexConf = new(mapper =>
		{
			// Map dữ liệu từ AppUser sang UserListItemVM, map thuộc tính RoleName
			mapper.CreateMap<AppUser, UserListItemVM>()
				.ForMember(uItem => uItem.RoleName, opts => opts.MapFrom(uEntity => uEntity.AppRole.Name));
		});

		// Cấu hình mapping cho AccountController, action Login
		public static MapperConfiguration LoginConf = new(mapper =>
		{
			// Map dữ liệu từ AppUser sang UserListItemVM, map thuộc tính RoleName
			mapper.CreateMap<AppUser, UserDataForApp>()
				.ForMember(uItem => uItem.RoleName, opts => opts.MapFrom(uEntity => uEntity.AppRole == null ? "" : uEntity.AppRole.Name))
				.ForMember(uItem => uItem.Permission, opts => opts.MapFrom
				(
					uEntity => string.Join(',', uEntity.AppRole
														.AppRolePermissions
														.Select(p => p.MstPermissionId))
				)
			);
		});

		// Cấu hình mapping cho RoleController, action Delete
		public static MapperConfiguration RoleDeleteConf = new(mapper =>
		{
			// Map dữ liệu thuộc tính con
			mapper.CreateMap<AppUser, RoleDeleteVM_User>();
			// Map dữ liệu thuộc tính cha
			mapper.CreateMap<AppRole, RoleDeleteVM>();
		});

		// Cấu hình mapping cho CompanyController, action Index
		public static MapperConfiguration CompanyIndexConf = new(mapper =>
		{
			mapper.CreateMap<AppCompany, CompanyListItemVM>()
				.ForMember(uItem => uItem.IsHidden, opts => opts.MapFrom(uEntity => uEntity.DeletedDate != null))
				.ForMember(uItem => uItem.DepartmentCount, opts => opts.MapFrom(uEntity => uEntity.Departments.Count))
				.ForMember(uItem => uItem.DepartmentHiddenCount, opts => opts.MapFrom(uEntity => uEntity.Departments.Where(item => item.DeletedDate != null).Count()));
		});

		// Cấu hình mapping cho CompanyPatientController, action Index
		public static MapperConfiguration CompanyPatientIndexConf = new(mapper =>
		{
			mapper.CreateMap<AppCompanyPatient, PatientListItemVM>()
				.ForMember(uItem => uItem.DepartmentName, opts => opts.MapFrom(uEntity => uEntity.Department.Name))
				.ForMember(uItem => uItem.CompanyName, opts => opts.MapFrom(uEntity => uEntity.AppCompany.Name))
				.ForMember(uItem => uItem.IsLastHistoryDone,
						opts => opts.MapFrom(uEntity => uEntity.PatientHistories.OrderByDescending(p => p.Id).FirstOrDefault().IsDone))
				.ForMember(uItem => uItem.ExamDate,
						opts => opts.MapFrom(uEntity => uEntity.PatientHistories.OrderByDescending(p => p.Id).FirstOrDefault().ExamDate))
				.ForMember(uItem => uItem.PrintCount,
						opts => opts.MapFrom(uEntity => uEntity.PatientHistories.OrderByDescending(p => p.Id).FirstOrDefault().PrintCount));
		});

		// Cấu hình mapping cho ExportData bệnh nhân
		public static MapperConfiguration PatientExportDataConf = new(mapper =>
		{
			mapper.CreateMap<AppCompanyPatient, ExportData>()
				.ForMember(uItem => uItem.IsLastHistoryDone,
						opts => opts.MapFrom(uEntity => uEntity.PatientHistories.OrderByDescending(p => p.Id).FirstOrDefault().IsDone))
				.ForMember(uItem => uItem.ExamDate,
						opts => opts.MapFrom(uEntity => uEntity.PatientHistories.OrderByDescending(p => p.Id).FirstOrDefault().ExamDate))
				.ForMember(uItem => uItem.Height,
						opts => opts.MapFrom(uEntity => uEntity.PatientHistories.OrderByDescending(p => p.Id).FirstOrDefault().Height))
				.ForMember(uItem => uItem.Weigth,
						opts => opts.MapFrom(uEntity => uEntity.PatientHistories.OrderByDescending(p => p.Id).FirstOrDefault().Weigth))
				.ForMember(uItem => uItem.BloodPressure,
						opts => opts.MapFrom(uEntity => uEntity.PatientHistories.OrderByDescending(p => p.Id).FirstOrDefault().BloodPressure))
				.ForMember(uItem => uItem.InternalMedicine,
						opts => opts.MapFrom(uEntity => uEntity.PatientHistories.OrderByDescending(p => p.Id).FirstOrDefault().InternalMedicine))
				.ForMember(uItem => uItem.ExternalMedicine,
						opts => opts.MapFrom(uEntity => uEntity.PatientHistories.OrderByDescending(p => p.Id).FirstOrDefault().ExternalMedicine))
				.ForMember(uItem => uItem.Ophthalmology,
						opts => opts.MapFrom(uEntity => uEntity.PatientHistories.OrderByDescending(p => p.Id).FirstOrDefault().Ophthalmology))
				.ForMember(uItem => uItem.Otorhinolaryngology,
						opts => opts.MapFrom(uEntity => uEntity.PatientHistories.OrderByDescending(p => p.Id).FirstOrDefault().Otorhinolaryngology))
				.ForMember(uItem => uItem.Dentomaxillofacial,
						opts => opts.MapFrom(uEntity => uEntity.PatientHistories.OrderByDescending(p => p.Id).FirstOrDefault().Dentomaxillofacial))
				.ForMember(uItem => uItem.Test,
						opts => opts.MapFrom(uEntity => uEntity.PatientHistories.OrderByDescending(p => p.Id).FirstOrDefault().Test))
				.ForMember(uItem => uItem.Classification,
						opts => opts.MapFrom(uEntity => uEntity.PatientHistories.OrderByDescending(p => p.Id).FirstOrDefault().Classification))
				.ForMember(uItem => uItem.Note,
						opts => opts.MapFrom(uEntity => uEntity.PatientHistories.OrderByDescending(p => p.Id).FirstOrDefault().Note))
				;
		});

		// Cấu hình mapping cho xem lịch sử khám bệnh nhân
		public static MapperConfiguration PatientHistoryConf = new(mapper =>
		{
			// Map dữ liệu bảng con
			mapper.CreateMap<AppCompanyPatientHistory, PatientHistoryVM>().ReverseMap();
			// Map dữ liệu bảng cha
			mapper.CreateMap<AppCompanyPatient, PatientHistoryListVM>().ReverseMap();
		});
	}
}
