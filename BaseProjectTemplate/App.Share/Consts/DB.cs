using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Share.Consts
{
	public static class DB
	{
		public static class AppRole
		{
			public const string TABLE_NAME					= "AppRole";
			public const short NAME_LENGTH					= 50;
			public const short DESC_LENGTH					= 100;
		}
		public static class AppRolePermission
		{
			public const string TABLE_NAME					= "AppRolePermission";
		}
		public static class AppUser
		{
			public const string TABLE_NAME					= "AppUser";
			public const short USERNAME_LENGTH				= 200;
			public const short PWD_LENGTH					= 200;
			public const short FULLNAME_LENGTH				= 50;
			public const short PHONE_LENGTH					= 20;
			public const short EMAIL_LENGTH					= 200;
			public const short ADDRESS_LENGTH				= 100;
			public const short AVATAR_LENGTH				= 200;
		}
		public static class MstPermission
		{
			public const string TABLE_NAME					= "MstPermission";
			public const short CODE_LENGTH					= 50;
			public const short TABLE_LENGTH					= 50;
			public const short GROUPNAME_LENGHT				= 100;
			public const short DESC_LENGHT					= 100;
		}
		public static class AppCompany
		{
			public const string TABLE_NAME					= "AppCompany";
			public const short CODE_LENGTH					= 50;
			public const short NAME_LENGHT					= 200;
		}
		public static class AppCompanyDepartment
		{
			public const string TABLE_NAME					= "AppCompanyDepartment";
			public const short NAME_LENGHT					= 200;
		}
		public static class AppCompanyPatient
		{
			public const string TABLE_NAME					= "AppCompanyPatient";
			public const short EMPLOYEE_CODE_LENGHT			= 100;
			public const short FULLNAME_LENGHT				= 200;
			public const short FULLNAME_NOACCENT_LENGHT		= 200;
			public const short IDENTITY_CODE_LENGHT			= 30;
			public const short IDENTITY_POI_LENGHT			= 200;
			public const short ADDRESS_LENGHT				= 300;
		}
		public static class AppCompanyPatientImported
		{
			public const string TABLE_NAME					= "AppCompanyPatientImported";
			public const short EMPLOYEE_CODE_LENGHT			= 100;
			public const short FULLNAME_LENGHT				= 200;
			public const short FULLNAME_NOACCENT_LENGHT		= 200;
			public const short IDENTITY_CODE_LENGHT			= 30;
			public const short IDENTITY_POI_LENGHT			= 200;
			public const short ADDRESS_LENGHT				= 300;
		}
		public static class AppCompanyPatientHistory
		{
			public const string TABLE_NAME					= "AppCompanyPatientHistory";
			public const short BLOOD_PRESSURE_LENGHT		= 50;
			public const short INTERNAL_MEDICINE_LENGHT		= 50;
			public const short EXTERNAL_MEDICINE_LENGHT		= 50;
			public const short OPHTHALMOLOGY_LENGHT			= 50;
			public const short OTORHINOLARYNGOLOGY_LENGHT	= 50;
			public const short DENTOMAXILLOFACIAL_LENGHT	= 50;
			public const short TEST_LENGHT					= 50;
			public const short CLASSIFICATION_LENGHT		= 20;
			public const short NOTE_LENGHT					= 1000;
			public const short REASON_LENGTH				= 1000;
		}
	}
}
