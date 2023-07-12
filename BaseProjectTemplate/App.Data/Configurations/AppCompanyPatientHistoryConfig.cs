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
	public class AppCompanyPatientHistoryConfig : IEntityTypeConfiguration<AppCompanyPatientHistory>
	{
		public void Configure(EntityTypeBuilder<AppCompanyPatientHistory> builder)
		{
			builder.ToTable(DB.AppCompanyPatientHistory.TABLE_NAME);

			// Khóa chính
			builder.HasKey(m => m.Id);

			builder.Property(m => m.BloodPressure)
				.HasMaxLength(DB.AppCompanyPatientHistory.BLOOD_PRESSURE_LENGHT);

			builder.Property(m => m.InternalMedicine)
				.HasMaxLength(DB.AppCompanyPatientHistory.INTERNAL_MEDICINE_LENGHT);

			builder.Property(m => m.ExternalMedicine)
				.HasMaxLength(DB.AppCompanyPatientHistory.EXTERNAL_MEDICINE_LENGHT);

			builder.Property(m => m.Ophthalmology)
				.HasMaxLength(DB.AppCompanyPatientHistory.OPHTHALMOLOGY_LENGHT);

			builder.Property(m => m.Otorhinolaryngology)
				.HasMaxLength(DB.AppCompanyPatientHistory.OTORHINOLARYNGOLOGY_LENGHT);

			builder.Property(m => m.Dentomaxillofacial)
				.HasMaxLength(DB.AppCompanyPatientHistory.DENTOMAXILLOFACIAL_LENGHT);

			builder.Property(m => m.Test)
				.HasMaxLength(DB.AppCompanyPatientHistory.TEST_LENGHT);

			builder.Property(m => m.Classification)
				.HasMaxLength(DB.AppCompanyPatientHistory.CLASSIFICATION_LENGHT);

			builder.Property(m => m.Note)
				.HasMaxLength(DB.AppCompanyPatientHistory.NOTE_LENGHT);

			builder.Property(m => m.Reason)
				.HasMaxLength(DB.AppCompanyPatientHistory.REASON_LENGTH);
		}
	}
}
