using Microsoft.EntityFrameworkCore;
using Budget_tracker_v1.Models;
namespace Budget_tracker_v1.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        // Define a DbSet for each of your model classes
        //public DbSet<Account> Accounts { get; set; }
        //public DbSet<Budget> Budgets { get; set; }
        //public DbSet<Expense> Expenses { get; set; }
        //public DbSet<FinancialGoal> FinancialGoals { get; set; }
        //public DbSet<Income> Incomes { get; set; }
        //public DbSet<Transaction> Transactions { get; set; }
        public DbSet<User> Users { get; set; }

        // Optionally, override the OnModelCreating method to configure your model relationships and database schema further
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // For example, if you have any fluent API configurations for your entities, they would go here
            // modelBuilder.Entity<User>().ToTable("AspNetUsers");
            // ... other configurations
        }

    }
}
