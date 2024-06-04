using MVC_CRUD.IServices;
using MVC_CRUD.Services;

namespace MVC_CRUD
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddTransient<IProductServices, ProductServices>();
            // Add services to the container.
            // Transient: Vòng đời ngắn nhất - cần gọi đến Services thì nó sẽ được tạo ra. 
            // Scope: Cũng được tạo ra nhưng sống cho đến khi Hết request chứa nó.
            // Singleton: Tạo ra và sống cho đến khi app hẹo.
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}