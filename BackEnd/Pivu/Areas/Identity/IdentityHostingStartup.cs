using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Pivu.Areas.Identity.Data;
using Pivu.Data;

[assembly: HostingStartup(typeof(Pivu.Areas.Identity.IdentityHostingStartup))]
namespace Pivu.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<PivuContextIdentity>(options =>
                    options.UseOracle(
                        context.Configuration.GetConnectionString("PivuContextConnection")));

                services.AddDefaultIdentity<PivuUserIdentity>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<PivuContextIdentity>();
            });
        }
    }
}