namespace GitÖvning
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("hej");
            Console.WriteLine("hej igen");


            var builderBob = WebApplication.CreateBuilder(args); //ammara ändrar

            // Add services to the container.
            builderBob.Services.AddControllersWithViews();

            var app = builder.Build();
            //Branch kommentar
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
