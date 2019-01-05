﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace _04_ContentNegotiation
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
            //services.AddMvc(
            //    config =>
            //    {


            //        config.RespectBrowserAcceptHeader = true;
            //        config.ReturnHttpNotAcceptable = true;
            //        config.InputFormatters.Add(new XmlSerializerInputFormatter());
            //        config.OutputFormatters.Add(new XmlSerializerOutputFormatter());
            //    });
            //// services.AddMvc().AddXmlSerializerFormatters();
          
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2)
               ;
          
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }
}
