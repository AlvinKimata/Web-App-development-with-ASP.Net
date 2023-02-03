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

        public void Configure(IApplicationBuilder app, IHostingEnvironment env, 
            ILogger<Startup> logger)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.Use(async (context, next) =>
            {
                logger.LogInformation("MW1: Incoming request.");
                await next();
                logger.LogInformation("MW1: Outgoing response..");
            });

            app.Use(async (context, next) =>
            {
                logger.LogInformation("MW2: Incoming request.");
                await next();
                logger.LogInformation("MW2: Outgoing response..");
            });


            app.Run(async (context) =>
                {
                    await context.Response
                        .WriteAsync("M3: Request handled and response produced.");
                    logger.LogInformation("MW3: Outgoing response.");
                });
        }

     }
}
