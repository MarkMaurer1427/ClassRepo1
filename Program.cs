using WebApp1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.SqlServer;

namespace WebApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllersWithViews();
            builder.Services.AddTransient<IBookRepository, SqlBookRepo>();
            builder.Services.AddDbContextPool<AppDBContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("BookDBConnect")));

            var app = builder.Build();
            app.UseExceptionHandler("/Error/");
            if(!app.Environment.IsDevelopment()) {
                app.UseStatusCodePagesWithRedirects("/Error/{0}");
            }

            
            app.UseRouting();
            //app.UseDefaultFiles();
            app.UseStaticFiles();

            //app.MapGet("/", () => "Hello World!");

            app.MapControllerRoute(
                    name: "default",
                    pattern:"{controller=home}/{action=index}/{id?}"
                );



            app.Run();
        }
    }
}