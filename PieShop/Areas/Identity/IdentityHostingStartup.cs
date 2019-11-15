using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(PieShop.Areas.Identity.IdentityHostingStartup))]
namespace PieShop.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) =>
            {
            });
        }
    }
}