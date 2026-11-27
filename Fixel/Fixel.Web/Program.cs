using EntityFramework.Exceptions.SqlServer;
using Fixel.Core.Customers;
using Fixel.Core.DeviceModels;
using Fixel.Core.Devices;
using Fixel.Core.RepairTickets;
using Fixel.Data;
using Microsoft.EntityFrameworkCore;

namespace Fixel.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<AppDbContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")
                                     ?? throw new InvalidOperationException(
                                         "Connection string 'DefaultConnection' not found"))
                    .UseExceptionProcessor();
            });

            builder.Services.AddScoped<ICustomerService, CustomerService>();
            builder.Services.AddScoped<IRepairTicketService, RepairTicketService>();
            builder.Services.AddScoped<IDeviceService, DeviceService>();
            builder.Services.AddScoped<IDeviceModelService, DeviceModelService>();

            var app = builder.Build();

            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseRouting();

            app.UseAuthorization();

            app.MapStaticAssets();
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}")
                .WithStaticAssets();

            app.Run();
        }
    }
}
