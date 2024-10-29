namespace GitÖvning
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("hej");
            Console.WriteLine("hej igen");
            var builder = WebApplication.CreateBuilder(args);
>>>>>>> 3c37b5e2c3208556cbbb3f2f11ec3e180d684986

            var builder = WebApplication.CreateBuilder(args); //ammara ändrar

            // Add services to the container.
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
                pattern: "{controller=Home}/{action=Index}/{id?}"
            );

            app.Run();
        }
    }
}
