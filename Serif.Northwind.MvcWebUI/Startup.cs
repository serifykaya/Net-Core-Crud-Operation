using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Serif.Northwind.Business.Abstract;
using Serif.Northwind.Business.Concrete;
using Serif.Northwind.DataAccess.Abstract;
using Serif.Northwind.DataAccess.Concrete.EntityFramework;

namespace Serif.Northwind.MvcWebUI
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //servis yapılandırılması
            services.AddScoped<IProductService, ProductManager>();
            services.AddScoped<IProductDal, EfProductDal>();
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }


            //home controllerın index sayfasına git demek
            app.UseMvcWithDefaultRoute();


            //app.UseMvc(routes =>
            //{
            //    routes.MapRoute
            //        (
            //        name: "Default",
            //        template: "{controller=home}/{action=index}/{id?}"
            //        );

            //});

        }
    }
}
