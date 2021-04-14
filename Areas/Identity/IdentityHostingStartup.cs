using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SchoolBussWebApp.Data;

[assembly: HostingStartup(typeof(SchoolBussWebApp.Areas.Identity.IdentityHostingStartup))]
namespace SchoolBussWebApp.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<SchoolBussIdentityContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("SqlConn")));

                services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<SchoolBussIdentityContext>();
            });
        }
    }
}