using App.Data.DataSeeders;
using App.Data.Entities;
using App.Data.Entities.Base;
using App.Share.Consts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Data.Configurations
{
	public class AppCompanyPatientImportedConfig : IEntityTypeConfiguration<AppCompanyPatientImported>
	{
		public void Configure(EntityTypeBuilder<AppCompanyPatientImported> builder)
		{
			builder.ToTable(DB.AppCompanyPatientImported.TABLE_NAME);

			// Khóa chính
			builder.HasKey(m => m.Id);
			builder.Property(m => m.EmployeeCode)
				.HasMaxLength(DB.AppCompanyPatientImported.EMPLOYEE_CODE_LENGHT);
			builder.HasIndex(m => m.EmployeeCode).IsUnique(false);

			builder.Property(m => m.FullName)
				.HasMaxLength(DB.AppCompanyPatientImported.FULLNAME_LENGHT);

			builder.Property(m => m.FullNameNoAccent)
				.HasMaxLength(DB.AppCompanyPatientImported.FULLNAME_NOACCENT_LENGHT);

			builder.Property(m => m.IdentityCode)
				.HasMaxLength(DB.AppCompanyPatientImported.IDENTITY_CODE_LENGHT);
			builder.HasIndex(m => m.IdentityCode).IsUnique(false);

			builder.Property(m => m.IdentityPoI)
				.HasMaxLength(DB.AppCompanyPatientImported.IDENTITY_POI_LENGHT);

			builder.Property(m => m.Address)
				.HasMaxLength(DB.AppCompanyPatientImported.ADDRESS_LENGHT);

			// Khóa ngoại
			builder.HasOne(m => m.Department)
				.WithMany()
				.HasForeignKey(m => m.DepartmentId);

			builder.HasOne(m => m.AppCompany)
				.WithMany()
				.HasForeignKey(m => m.CompanyId);
		}
	}
}
