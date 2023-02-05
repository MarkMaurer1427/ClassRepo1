using WebApp1.Models;

namespace WebApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllersWithViews();
            builder.Services.AddSingleton<IBookRepository, BookRepo>();

            var app = builder.Build();



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