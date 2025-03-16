using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using SelfSampleProRAD;
using SelfSampleProRAD_DB.Data;

namespace SelfSampleProRAD_DB
{
    internal static class Program
    {
        public static IConfiguration Configuration { get; private set; }
        public static IServiceProvider ServiceProvider { get; private set; }

        [STAThread]
        static void Main()
        {
            if (IsRunningUnderEfCoreTooling())
                return;

            Configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var services = new ServiceCollection();

            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            ServiceProvider = services.BuildServiceProvider();

            ApplicationConfiguration.Initialize();

            using (var scope = ServiceProvider.CreateScope())
            {
                var context = scope.ServiceProvider.GetRequiredService<AppDbContext>();

                try
                {
                    context.Database.EnsureCreated();

                    var seeder = new SuperAdminSeeder(context);
                    seeder.SeedSuperAdmin();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Database error: {ex.Message}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Environment.Exit(0);
                }
            }

            Application.Run(new CompleteForm());
        }

        private static bool IsRunningUnderEfCoreTooling()
        {
            return AppDomain.CurrentDomain
                .GetAssemblies()
                .Any(a => a.FullName.StartsWith("Microsoft.EntityFrameworkCore.Design"));
        }
    }
}
