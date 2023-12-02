using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using VehiculeApp.Data;
using VehiculeApp.Data.Interfaces;
using VehiculeApp.Data.mocks;

namespace VehiculeApp
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IVehiculeRepository, MockVehiculeRepository>();
            services.AddTransient<ICategoryRepository, MockCategoryRepository>();
            services.AddMvc();
        }
        public void Configure(WebApplication app, IWebHostEnvironment env ,ILoggerFactory loggerFactory)
        {
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseMvcWithDefaultRoute();
        }
    }
}
