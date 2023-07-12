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
	public class AppCompanyPatientConfig : IEntityTypeConfiguration<AppCompanyPatient>
	{
		public void Configure(EntityTypeBuilder<AppCompanyPatient> builder)
		{
			builder.ToTable(DB.AppCompanyPatient.TABLE_NAME);

			// Khóa chính
			builder.HasKey(m => m.Id);
			builder.Property(m => m.EmployeeCode)
				.HasMaxLength(DB.AppCompanyPatient.EMPLOYEE_CODE_LENGHT);
			builder.HasIndex(m => m.EmployeeCode).IsUnique(false);

			builder.Property(m => m.FullName)
				.HasMaxLength(DB.AppCompanyPatient.FULLNAME_LENGHT);

			builder.Property(m => m.FullNameNoAccent)
				.HasMaxLength(DB.AppCompanyPatient.FULLNAME_NOACCENT_LENGHT);

			builder.Property(m => m.IdentityCode)
				.HasMaxLength(DB.AppCompanyPatient.IDENTITY_CODE_LENGHT);
			builder.HasIndex(m => m.IdentityCode).IsUnique(false);

			builder.Property(m => m.IdentityPoI)
				.HasMaxLength(DB.AppCompanyPatient.IDENTITY_POI_LENGHT);

			builder.Property(m => m.Address)
				.HasMaxLength(DB.AppCompanyPatient.ADDRESS_LENGHT);

			// Khóa ngoại
			builder.HasMany(m => m.PatientHistories)
				.WithOne(m => m.Patient)
				.HasForeignKey(m => m.CompanyPatientId);

			builder.HasOne(m => m.Department)
				.WithMany(m => m.Patients)
				.HasForeignKey(m => m.DepartmentId);

			builder.HasOne(m => m.AppCompany)
				.WithMany(m => m.CompanyPatients)
				.HasForeignKey(m => m.CompanyId);
		}
	}
}
