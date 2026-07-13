namespace GRUPOMT
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // 1. Obtener las cadenas de conexión desde appsettings.json
            var connectionToyo = builder.Configuration.GetConnectionString("ConexionToyo");
            var connectionSakura = builder.Configuration.GetConnectionString("ConexionSakura");

            // 2. Registrar los contextos de base de datos
            // Asegúrate de tener instalados los paquetes de EF Core (Microsoft.EntityFrameworkCore.SqlServer)
            // builder.Services.AddDbContext<ToyoDbContext>(options => options.UseSqlServer(connectionToyo));
            // builder.Services.AddDbContext<SakuraDbContext>(options => options.UseSqlServer(connectionSakura));

            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // ... (resto del código del pipeline se mantiene igual)
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=GrupoMT}/{action=GrupoMT}/{id?}");

            app.Run();
        }
    }
}