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
	public class AppCompanyConfig : IEntityTypeConfiguration<AppCompany>
	{
		public void Configure(EntityTypeBuilder<AppCompany> builder)
		{
			builder.ToTable(DB.AppCompany.TABLE_NAME);

			// Khóa chính
			builder.HasKey(m => m.Id);

			builder.Property(m => m.CompanyCode)
				.HasMaxLength(DB.AppCompany.CODE_LENGTH);

			builder.Property(m => m.Name)
				.HasMaxLength(DB.AppCompany.NAME_LENGHT);

		}
	}
}
