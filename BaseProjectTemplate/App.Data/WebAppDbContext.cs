﻿using App.Data.Configurations;
using App.Data.DataSeeders;
using App.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Data
{
	public class WebAppDbContext : DbContext
	{
		public DbSet<AppRole> AppPolicies { get; set; }
		public DbSet<AppRolePermission> AppRolePermissions { get; set; }
		public DbSet<AppUser> AppUsers { get; set; }
		public DbSet<MstPermission> MstPermissions { get; set; }
		public DbSet<AppCompany> AppCompanies { get; set; }
		public DbSet<AppCompanyDepartment> AppCompanyDepartments { get; set; }
		public DbSet<AppCompanyPatient> AppCompanyPatients { get; set; }
		public DbSet<AppCompanyPatientImported> AppCompanyPatientImporteds { get; set; }
		public DbSet<AppCompanyPatientHistory> AppCompanyPatientHistories { get; set; }

		public WebAppDbContext(DbContextOptions options) : base(options)
		{
		}
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfiguration(new AppUserConfig());
			modelBuilder.ApplyConfiguration(new AppRoleConfig());
			modelBuilder.ApplyConfiguration(new AppRolePermissionConfig());
			modelBuilder.ApplyConfiguration(new MstPermissionConfig());
			modelBuilder.ApplyConfiguration(new AppCompanyConfig());
			modelBuilder.ApplyConfiguration(new AppCompanyDepartmentConfig());
			modelBuilder.ApplyConfiguration(new AppCompanyPatientConfig());
			modelBuilder.ApplyConfiguration(new AppCompanyPatientImportedConfig());
			modelBuilder.ApplyConfiguration(new AppCompanyPatientHistoryConfig());

			// Tạo dữ liệu
			modelBuilder.Entity<MstPermission>().SeedData();
			modelBuilder.Entity<AppRole>().SeedData();
			modelBuilder.Entity<AppRolePermission>().SeedData();

			// Mở khóa comment để tạo thông tin admin và quyền
			// Do mỗi lần seed data sẽ có password khác nhau nên chỉ cần chạy 1 lần rồi comment lại
			//modelBuilder.Entity<AppUser>().SeedData();
		}
	}
}