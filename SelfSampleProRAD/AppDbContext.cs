using SelfSampleProRAD_DB.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace SelfSampleProRAD_DB
{
    public class AppDbContext : DbContext
    {
        private readonly string _connectionString;

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        // This constructor is used for migrations
        public AppDbContext()
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(_connectionString);
            }
        }

        public DbSet<Account> Account { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Tasks> Tasks { get; set; }
        public DbSet<EmployeeTasks> EmployeeTasks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            // Configure Account
            modelBuilder.Entity<Account>()
                .HasKey(a => a.UserId);

            // Configure Employee
            modelBuilder.Entity<Employee>()
                .HasKey(e => e.EmployeeId);

            // Configure Tasks
            modelBuilder.Entity<Tasks>()
                .HasKey(t => t.TaskId);

            // Configure Relationships
            modelBuilder.Entity<Employee>()
                .HasOne(e => e.Account)
                .WithOne(a => a.Employee)
                .HasForeignKey<Employee>(e => e.UserId)
                .IsRequired(false);

            // EmployeeTasks
            modelBuilder.Entity<EmployeeTasks>()
                .HasKey(et => et.ETID);

            modelBuilder.Entity<EmployeeTasks>()
                .HasOne(e => e.Employees)
                .WithMany(et => et.EmployeeTasks)
                .HasForeignKey(et => et.EmployeeId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<EmployeeTasks>()
                .HasOne(t => t.Tasks)
                .WithMany(t => t.EmployeeTasks)
                .HasForeignKey(et => et.TaskId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
