using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ETrade.BusinessLayer.Abstract;
using ETrade.BusinessLayer.Concrete;
using ETrade.DataAccess.Abstract;
using ETrade.DataAccess.Concrete.EntityFramework;
using ETrade.WebMvcUI.Middlewares;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace ETrade.WebMvcUI
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IProductService, ProductManager>();
            services.AddScoped<IProductDAL, EfProductDal>();
            services.AddMvc(MvcOptions=>MvcOptions.EnableEndpointRouting = false);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();                
            }

            app.UseStaticFiles();
            app.UseNodeModules(env.ContentRootPath);

            //app.UseRouting();

            //app.UseMvcWithDefaultRoute();

            app.UseMvc(ConfigureRoutes);
        }

        private void ConfigureRoutes(IRouteBuilder routeBuilder)
        {
            routeBuilder.MapRoute("Default", "{Controller=Home}/{Action=Index}/{id?}");
        }
    }
}
