﻿using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Venezia.Data;

[assembly: HostingStartup(typeof(Venezia.Areas.Identity.IdentityHostingStartup))]
namespace Venezia.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<VeneziaContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("VeneziaContext")));

                //services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                  //  .AddEntityFrameworkStores<VeneziaContext>();
            });
        }
    }
}