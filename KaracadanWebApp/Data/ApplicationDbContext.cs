using KaracadanWebApp.Core.Domain;
using KaracadanWebApp.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace KaracadanWebApp.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }


        public DbSet<Employee> Employees { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<CustomerAccount> CustomerAccounts { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Expence> Expences { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Employee>(entity =>
            {
                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Email)
                    .IsRequired(false)
                    .HasMaxLength(100);

                entity.Property(e => e.PhoneNumber)
                    .IsRequired(false)
                    .HasMaxLength(100);

                entity.Property(e => e.Password)
                    .IsRequired(false)
                    .HasMaxLength(100);
            });

            base.OnModelCreating(builder);
        }
    }
}
