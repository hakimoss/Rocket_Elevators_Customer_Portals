using System;
using Customer_Portal.Areas.Identity.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Pomelo.EntityFrameworkCore.MySql;


[assembly: HostingStartup(typeof(Customer_Portal.Areas.Identity.IdentityHostingStartup))]
namespace Customer_Portal.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                // services.AddDbContext<Customer_PortalIdentityDbContext>(options =>
                //     options.UseMySql(
                        // context.Configuration.GetConnectionString("Customer_PortalIdentityDbContextConnection")));

                services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<Customer_PortalIdentityDbContext>();
            });
        }
    }
}