using getster_attendance_app.Getster_DbContext;
using getster_attendance_app.Repository.Attendance_App_Dynamic_Db;
using getster_attendance_app.Repository.Userapp_Approval_Of_Over_Time;
using getster_attendance_app.Repository.Userapp_Audit_Trail_For_Work_Schedule_Shifts;
using getster_attendance_app.Repository.Userapp_Work_Break_Timings_Master_Data;
using getster_attendance_app.Repository.Userapp_Work_Holidays_Master_Data;
using getster_attendance_app.Repository.Userapp_Work_Schedule_Categories_Master;
using getster_attendance_app.Repository.Userapp_Work_Shift_Changeover_Schedule;
using getster_attendance_app.Repository.Userapp_Work_Shift_Timings_Master_Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace getster_attendance_app
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            String mySqlConnectionStr = Configuration.GetConnectionString("DefaultConnection");
            services.AddDbContextPool<AttendanceApp_DbContext>(options => options.UseMySql(mySqlConnectionStr, ServerVersion.AutoDetect(mySqlConnectionStr)));


            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "getster_attendance_app", Version = "v1" });
            });

            services.AddScoped<IAttendanceAppDynamicDbRepository, AttendanceAppDynamicDbRepository>();
            services.AddScoped<IUserappWorkShiftTimingsMasterDataRepository, UserappWorkShiftTimingsMasterDataRepository>();
            services.AddScoped<IUserappWorkBreakTimingsMasterDataRepository, UserappWorkBreakTimingsMasterDataRepository>();
            services.AddScoped<IUserappAuditTrailForWorkScheduleShiftsRepository, UserappAuditTrailForWorkScheduleShiftsRepository>();
            services.AddScoped<IUserappWorkShiftChangeoverScheduleRepository, UserappWorkShiftChangeoverScheduleRepository>();
            services.AddScoped<IUserappWorkScheduleCategoriesMasterDataRepository, UserappWorkScheduleCategoriesMasterDataRepository>();
            services.AddScoped<IUserappWorkHolidaysMasterDataRepository, UserappWorkHolidaysMasterDataRepository>();
            services.AddScoped<IUserappApprovalOfOverTimeRepository,UserappApprovalOfOverTimeRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "getster_attendance_app v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
