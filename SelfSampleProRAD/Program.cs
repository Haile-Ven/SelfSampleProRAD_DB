using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
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
            // Setup configuration
            Configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            // Setup services
            var services = new ServiceCollection();

            // Register DbContext
            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            ServiceProvider = services.BuildServiceProvider();

            ApplicationConfiguration.Initialize();

            using (var scope = ServiceProvider.CreateScope())
            {
                var context = scope.ServiceProvider.GetRequiredService<AppDbContext>();

                try
                {
                    // Ensure DB is created
                    context.Database.EnsureCreated();

                    // Run seeder
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
    }
}
