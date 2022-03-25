using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using SepahMD.DataLayer.Context;
using SepahMD.Core;
using SepahMD.Core.Services;

namespace SepahMD.Web
{
    public class Startup
    {
        public IConfiguration Myconfiguration { get; }
        public Startup(IConfiguration configuration)
        {
            Myconfiguration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {

            services.AddDbContext<Refahi_db>(options =>
            {
                options.UseSqlServer(Myconfiguration.GetConnectionString("Con1"));
            });
            services.AddScoped<ICity,CityServices>();
            services.AddScoped<IDoctor,DoctorServices>();   
            services.AddScoped<IDoctorType,DoctorTypeServices>();
            services.AddScoped<IInsurance,InsuranceServices>();

            services.AddRazorPages();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseStaticFiles();
            app.UseAuthorization();
            app.UseHttpsRedirection();
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                //endpoints.MapGet("/", async context =>
                //{
                //    await context.Response.WriteAsync("Hello World!");
                //});
                endpoints.MapRazorPages();
            });
        }
    }
}
