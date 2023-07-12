using App.Data;
using App.Data.Repositories;
using App.Web.Common;
using App.Web.Common.Mailer;
using App.Web.Common.MemoryCacheTicketStore;
using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.Web.WebConfig
{
	public static class AppService
	{
		public static void AddAppService(this IServiceCollection services, IConfiguration Configuration, IWebHostEnvironment env)
		{
			services.AddDbContext<WebAppDbContext>(option =>
			{
				option.UseSqlServer(Configuration.GetConnectionString("Database"));
			});

			// Đăng ký repositories
			services.AddScoped<GenericRepository>();
			// Cấu hình đăng ký MemoryCacheTicketStore, dùng cho chức năng ép user đăng xuất, chỉ chạy trên Production
			// Ở môi trường Development thì tạm tắt đi cho tiện
			MemoryCacheTicketStore memoryCacheTicketStore = new MemoryCacheTicketStore();
			services.AddSingleton(memoryCacheTicketStore);
			if (env.IsDevelopment())
			{
				// Cấu hình đăng nhập môi trường Development
				services.AddAuthentication(AppConst.COOKIES_AUTH).AddCookie(options =>
				{
					options.LoginPath = AppConst.LOGIN_PATH;
					options.ExpireTimeSpan = TimeSpan.FromHours(AppConst.LOGIN_TIMEOUT);
					options.Cookie.HttpOnly = true;
				});
			}
			else
			{
				// Cấu hình đăng nhập môi trường Production
				services.AddAuthentication(AppConst.COOKIES_AUTH).AddCookie(options =>
				{
					options.LoginPath = AppConst.LOGIN_PATH;
					options.ExpireTimeSpan = TimeSpan.FromHours(AppConst.LOGIN_TIMEOUT);
					options.Cookie.HttpOnly = true;
					options.SessionStore = memoryCacheTicketStore;
				});
			}

			// Cấu hình AutoMapper
			var mapperConfig = new MapperConfiguration(config =>
			{
				config.AddProfile(new AutoMapperProfile());
			});
			IMapper mapper = mapperConfig.CreateMapper();
			services.AddSingleton(mapper);

			// Cấu hình thư mục view cho ViewComponent
			services.Configure<RazorViewEngineOptions>(config =>
			{
				// path: /Components/{component-name}/Default.cshtml
				config.ViewLocationFormats.Add("/{0}.cshtml");
			});

			// Khởi tạo thông tin mail
			AppMailConfiguration mailConfig = new();
			mailConfig.LoadFromConfig(Configuration);
			services.AddSingleton(mailConfig);

			// Cấu hình để sử dụng import/export excel
			ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
		}
	}
}
