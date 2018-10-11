using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WhatShouldWeEat.DataAccess.EntityFramework;

namespace WhatShouldWeEat.WebUI
{
    public class Startup
    {

        public void ConfigureServices(IServiceCollection services)
        {
            /*

            string connectionString = "User ID = fgtjtchj;Password = 8H1bUHfARAo9RD-kdV6oU9UuqeaueD59; Host = horton.elephantsql.com;Port = 5432;Database = fgtjtchj";
            services.AddEntityFrameworkNpgsql()
                    .AddDbContext<DataContext>(options => options.UseNpgsql(connectionString));

            */
            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseStaticFiles();

            app.UseMvcWithDefaultRoute();
        }
    }
}
