﻿// <auto-generated />
using System;
using App.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace App.Data.Migrations
{
    [DbContext(typeof(WebAppDbContext))]
    [Migration("20230615164749_add_col_history_tbl")]
    partial class add_col_history_tbl
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("App.Data.Entities.AppCompany", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CompanyCode")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int?>("UpdatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("AppCompany");
                });

            modelBuilder.Entity("App.Data.Entities.AppCompanyDepartment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CompanyId")
                        .HasColumnType("int");

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int?>("UpdatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("AppCompanyDepartment");
                });

            modelBuilder.Entity("App.Data.Entities.AppCompanyPatient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<int?>("DigitalInfo")
                        .HasColumnType("int");

                    b.Property<int?>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DoB")
                        .HasColumnType("datetime2");

                    b.Property<string>("EmployeeCode")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("FullName")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("FullNameNoAccent")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("IdentityCode")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<DateTime?>("IdentityDoI")
                        .HasColumnType("datetime2");

                    b.Property<string>("IdentityPoI")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime?>("ImportDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("UpdatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("YoB")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.ToTable("AppCompanyPatient");
                });

            modelBuilder.Entity("App.Data.Entities.AppCompanyPatientHistory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BloodPressure")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Classification")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int?>("CompanyPatientId")
                        .HasColumnType("int");

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Dentomaxillofacial")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ExamDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ExternalMedicine")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<float?>("Height")
                        .HasColumnType("real");

                    b.Property<string>("InternalMedicine")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("IsDone")
                        .HasColumnType("bit");

                    b.Property<string>("Note")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("Ophthalmology")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Otorhinolaryngology")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("Pulse")
                        .HasColumnType("int");

                    b.Property<string>("Reason")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("Test")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("UpdatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<float?>("Weigth")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.HasIndex("CompanyPatientId");

                    b.ToTable("AppCompanyPatientHistory");
                });

            modelBuilder.Entity("App.Data.Entities.AppRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Desc")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("UpdatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("AppRole");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Desc = "Quản trị toàn bộ hệ thống",
                            Name = "Quản trị hệ thống",
                            UpdatedDate = new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("App.Data.Entities.AppRolePermission", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AppRoleId")
                        .HasColumnType("int");

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<int>("MstPermissionId")
                        .HasColumnType("int");

                    b.Property<int?>("UpdatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("AppRoleId");

                    b.HasIndex("MstPermissionId");

                    b.ToTable("AppRolePermission");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AppRoleId = 1,
                            CreatedDate = new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            MstPermissionId = 1101,
                            UpdatedDate = new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            AppRoleId = 1,
                            CreatedDate = new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            MstPermissionId = 1102,
                            UpdatedDate = new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            AppRoleId = 1,
                            CreatedDate = new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            MstPermissionId = 1103,
                            UpdatedDate = new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 4,
                            AppRoleId = 1,
                            CreatedDate = new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            MstPermissionId = 1104,
                            UpdatedDate = new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 5,
                            AppRoleId = 1,
                            CreatedDate = new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            MstPermissionId = 1105,
                            UpdatedDate = new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 6,
                            AppRoleId = 1,
                            CreatedDate = new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            MstPermissionId = 1001,
                            UpdatedDate = new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 7,
                            AppRoleId = 1,
                            CreatedDate = new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            MstPermissionId = 1002,
                            UpdatedDate = new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 8,
                            AppRoleId = 1,
                            CreatedDate = new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            MstPermissionId = 1003,
                            UpdatedDate = new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 9,
                            AppRoleId = 1,
                            CreatedDate = new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            MstPermissionId = 1004,
                            UpdatedDate = new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 10,
                            AppRoleId = 1,
                            CreatedDate = new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            MstPermissionId = 1005,
                            UpdatedDate = new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 11,
                            AppRoleId = 1,
                            CreatedDate = new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            MstPermissionId = 1006,
                            UpdatedDate = new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 12,
                            AppRoleId = 1,
                            CreatedDate = new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            MstPermissionId = 1007,
                            UpdatedDate = new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 13,
                            AppRoleId = 1,
                            CreatedDate = new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            MstPermissionId = 1008,
                            UpdatedDate = new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 14,
                            AppRoleId = 1,
                            CreatedDate = new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            MstPermissionId = 1205,
                            UpdatedDate = new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("App.Data.Entities.AppUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("AppRoleId")
                        .HasColumnType("int");

                    b.Property<string>("Avatar")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int?>("BlockedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("BlockedTo")
                        .HasColumnType("datetime2");

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasMaxLength(200)
                        .IsUnicode(false)
                        .HasColumnType("varchar(200)");

                    b.Property<string>("FullName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<byte[]>("PasswordHash")
                        .HasMaxLength(200)
                        .HasColumnType("varbinary(200)");

                    b.Property<byte[]>("PasswordSalt")
                        .HasMaxLength(200)
                        .HasColumnType("varbinary(200)");

                    b.Property<string>("PhoneNumber1")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("PhoneNumber2")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<int?>("UpdatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(200)
                        .IsUnicode(false)
                        .HasColumnType("varchar(200)");

                    b.HasKey("Id");

                    b.HasIndex("AppRoleId");

                    b.HasIndex("Username")
                        .IsUnique();

                    b.ToTable("AppUser");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Thành phố Hồ Chí Minh",
                            AppRoleId = 1,
                            CreatedBy = -1,
                            CreatedDate = new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "admin_test@gmail.com",
                            FullName = "Obama",
                            PasswordHash = new byte[] { 6, 16, 62, 178, 200, 101, 217, 38, 223, 143, 102, 171, 133, 152, 213, 102, 214, 50, 24, 206, 96, 253, 142, 3, 23, 168, 140, 109, 143, 126, 236, 65, 47, 233, 47, 106, 79, 103, 7, 230, 12, 128, 174, 222, 208, 115, 176, 233, 15, 113, 195, 14, 166, 124, 219, 189, 160, 236, 164, 45, 130, 193, 186, 166 },
                            PasswordSalt = new byte[] { 170, 31, 26, 219, 37, 238, 255, 208, 7, 100, 44, 189, 80, 154, 25, 220, 95, 45, 182, 135, 71, 177, 42, 169, 227, 212, 233, 148, 203, 158, 52, 154, 60, 15, 16, 7, 147, 179, 214, 86, 232, 98, 102, 218, 65, 208, 57, 118, 161, 233, 213, 233, 1, 216, 193, 123, 47, 43, 15, 55, 240, 25, 14, 192, 15, 112, 130, 141, 194, 73, 218, 15, 82, 219, 225, 254, 91, 253, 98, 14, 202, 253, 215, 219, 14, 53, 132, 13, 118, 204, 110, 186, 41, 227, 180, 145, 168, 235, 5, 230, 212, 191, 30, 0, 51, 168, 64, 114, 140, 53, 125, 86, 215, 161, 238, 129, 230, 161, 187, 95, 10, 126, 120, 58, 242, 116, 100, 98 },
                            PhoneNumber1 = "0928666158",
                            PhoneNumber2 = "0928666156",
                            UpdatedBy = -1,
                            UpdatedDate = new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Username = "admin"
                        });
                });

            modelBuilder.Entity("App.Data.Entities.MstPermission", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Desc")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<string>("GroupName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Table")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("MstPermission");

                    b.HasData(
                        new
                        {
                            Id = 1103,
                            Code = "CREATE",
                            CreatedDate = new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Desc = "Thêm quyền",
                            GroupName = "Quản lý phân quyền",
                            Table = "AppRole"
                        },
                        new
                        {
                            Id = 1105,
                            Code = "DELETE",
                            CreatedDate = new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Desc = "Xóa quyền",
                            GroupName = "Quản lý phân quyền",
                            Table = "AppRole"
                        },
                        new
                        {
                            Id = 1104,
                            Code = "UPDATE",
                            CreatedDate = new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Desc = "Sửa quyền",
                            GroupName = "Quản lý phân quyền",
                            Table = "AppRole"
                        },
                        new
                        {
                            Id = 1102,
                            Code = "VIEW_DETAIL",
                            CreatedDate = new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Desc = "Xem chi tiết quyền",
                            GroupName = "Quản lý phân quyền",
                            Table = "AppRole"
                        },
                        new
                        {
                            Id = 1101,
                            Code = "VIEW_LIST",
                            CreatedDate = new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Desc = "Xem danh sách quyền",
                            GroupName = "Quản lý phân quyền",
                            Table = "AppRole"
                        },
                        new
                        {
                            Id = 1006,
                            Code = "BLOCK",
                            CreatedDate = new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Desc = "Khóa người dùng",
                            GroupName = "Quản lý người dùng",
                            Table = "AppUser"
                        },
                        new
                        {
                            Id = 1003,
                            Code = "CREATE",
                            CreatedDate = new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Desc = "Thêm người dùng",
                            GroupName = "Quản lý người dùng",
                            Table = "AppUser"
                        },
                        new
                        {
                            Id = 1008,
                            Code = "DELETE",
                            CreatedDate = new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Desc = "Xóa người dùng",
                            GroupName = "Quản lý người dùng",
                            Table = "AppUser"
                        },
                        new
                        {
                            Id = 1007,
                            Code = "UNBLOCK",
                            CreatedDate = new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Desc = "Mở khóa người dùng",
                            GroupName = "Quản lý người dùng",
                            Table = "AppUser"
                        },
                        new
                        {
                            Id = 1004,
                            Code = "UPDATE",
                            CreatedDate = new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Desc = "Cập nhật người dùng",
                            GroupName = "Quản lý người dùng",
                            Table = "AppUser"
                        },
                        new
                        {
                            Id = 1005,
                            Code = "UPDATE_PWD",
                            CreatedDate = new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Desc = "Đổi mật khẩu",
                            GroupName = "Quản lý người dùng",
                            Table = "AppUser"
                        },
                        new
                        {
                            Id = 1002,
                            Code = "VIEW_DETAIL",
                            CreatedDate = new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Desc = "Xem chi tiết người dùng",
                            GroupName = "Quản lý người dùng",
                            Table = "AppUser"
                        },
                        new
                        {
                            Id = 1001,
                            Code = "VIEW_LIST",
                            CreatedDate = new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Desc = "Xem danh sách người dùng",
                            GroupName = "Quản lý người dùng",
                            Table = "AppUser"
                        },
                        new
                        {
                            Id = 1205,
                            Code = "MANAGER",
                            CreatedDate = new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Desc = "Quản lý file hệ thống",
                            GroupName = "Quản lý file",
                            Table = "FileManager"
                        });
                });

            modelBuilder.Entity("App.Data.Entities.AppCompanyDepartment", b =>
                {
                    b.HasOne("App.Data.Entities.AppCompany", "Company")
                        .WithMany("Departments")
                        .HasForeignKey("CompanyId");

                    b.Navigation("Company");
                });

            modelBuilder.Entity("App.Data.Entities.AppCompanyPatient", b =>
                {
                    b.HasOne("App.Data.Entities.AppCompanyDepartment", "Department")
                        .WithMany("Patients")
                        .HasForeignKey("DepartmentId");

                    b.Navigation("Department");
                });

            modelBuilder.Entity("App.Data.Entities.AppCompanyPatientHistory", b =>
                {
                    b.HasOne("App.Data.Entities.AppCompanyPatient", "Patient")
                        .WithMany("PatientHistories")
                        .HasForeignKey("CompanyPatientId");

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("App.Data.Entities.AppRolePermission", b =>
                {
                    b.HasOne("App.Data.Entities.AppRole", "AppRole")
                        .WithMany("AppRolePermissions")
                        .HasForeignKey("AppRoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("App.Data.Entities.MstPermission", "MstPermission")
                        .WithMany("AppRolePermissions")
                        .HasForeignKey("MstPermissionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AppRole");

                    b.Navigation("MstPermission");
                });

            modelBuilder.Entity("App.Data.Entities.AppUser", b =>
                {
                    b.HasOne("App.Data.Entities.AppRole", "AppRole")
                        .WithMany("AppUsers")
                        .HasForeignKey("AppRoleId");

                    b.Navigation("AppRole");
                });

            modelBuilder.Entity("App.Data.Entities.AppCompany", b =>
                {
                    b.Navigation("Departments");
                });

            modelBuilder.Entity("App.Data.Entities.AppCompanyDepartment", b =>
                {
                    b.Navigation("Patients");
                });

            modelBuilder.Entity("App.Data.Entities.AppCompanyPatient", b =>
                {
                    b.Navigation("PatientHistories");
                });

            modelBuilder.Entity("App.Data.Entities.AppRole", b =>
                {
                    b.Navigation("AppRolePermissions");

                    b.Navigation("AppUsers");
                });

            modelBuilder.Entity("App.Data.Entities.MstPermission", b =>
                {
                    b.Navigation("AppRolePermissions");
                });
#pragma warning restore 612, 618
        }
    }
}
