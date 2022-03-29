#nullable disable
using Domain.Entities;
using Infrastructure.Configurations;
using Infrastructure.Utils;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Database
{
    public class ApplicationDbContext : IdentityDbContext<User, Role, int>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public virtual DbSet<Book> Book { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<OrderHistory> OrderHistory { get; set; }
        public virtual DbSet<OrderItem> OrderItem { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            foreach (var entityType in builder.Model.GetEntityTypes())
            {
                var tableName = entityType.GetTableName();
                if (tableName.StartsWith("AspNet"))
                {
                    entityType.SetTableName(tableName.Substring(6));
                }
            }

            builder.ApplyConfiguration(new BookEntityConfiguration());
            builder.ApplyConfiguration(new CategoryEntityConfiguration());
            builder.ApplyConfiguration(new OrderEntityConfiguration());
            builder.ApplyConfiguration(new OrderItemEntityConfiguration());
            this.SeedRoles(builder);
        }

        private void SeedRoles(ModelBuilder builder)
        {
            builder.Entity<Role>()
                .HasData(
                    new Role()
                    {
                      Id= 100,
                      Name = RoleConstant.Admin,
                      NormalizedName = RoleConstant.Admin.ToUpper()
                    },
                    new Role()
                    {
                        Id = 101,
                        Name = RoleConstant.StoreOwner,
                        NormalizedName = RoleConstant.StoreOwner.ToUpper()
                    },
                    new Role()
                    {
                        Id = 102,
                        Name = RoleConstant.Customer,
                        NormalizedName = RoleConstant.Customer.ToUpper()
                    });
        }

    }
}
