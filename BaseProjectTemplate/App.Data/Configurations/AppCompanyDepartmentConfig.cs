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
	public class AppCompanyDepartmentConfig : IEntityTypeConfiguration<AppCompanyDepartment>
	{
		public void Configure(EntityTypeBuilder<AppCompanyDepartment> builder)
		{
			builder.ToTable(DB.AppCompanyDepartment.TABLE_NAME);

			// Khóa chính
			builder.HasKey(m => m.Id);

			builder.Property(m => m.Name)
				.HasMaxLength(DB.AppCompanyDepartment.NAME_LENGHT);

			builder.HasOne(m=>m.Company)
				.WithMany(m=>m.Departments)
				.HasForeignKey(m => m.CompanyId);
		}
	}
}
