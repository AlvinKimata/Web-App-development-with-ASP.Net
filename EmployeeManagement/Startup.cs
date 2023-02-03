using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    public class Startup
    {
        private IConfiguration _config;
        public Startup(IConfiguration config)
        {
            _config = config;
        }
        //Method to add services.
        public void ConfigureServices(IServiceCollection services)
        {

        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            FileServerOptions fileServerOptions= new FileServerOptions();
            fileServerOptions.DefaultFileOptions.DefaultFileNames.Clear();
            fileServerOptions.DefaultFileOptions.DefaultFileNames.Add("foo.html");
            app.UseFileServer(fileServerOptions);


            app.Run(async (context) =>
                {
                    await context.Response
                        .WriteAsync("Hello.");
                });
        }
          
     }
}
