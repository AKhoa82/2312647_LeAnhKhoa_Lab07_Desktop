using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09_EntityFramework.Models
{
    public class RestaurantContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Food> Foods { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<RoleAccount> RoleAccounts { get; set; }
        public DbSet<Bills> Bills { get; set; }
        public DbSet<Table> Tables { get; set; }
        public DbSet<BillDetails> BillDetails { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Entity<RoleAccount>()
                .HasRequired(ra => ra.Role)
                .WithMany(r => r.RoleAccounts)
                .HasForeignKey(ra => ra.RoleID);

            modelBuilder.Entity<RoleAccount>()
                .HasRequired(ra => ra.Account)
                .WithMany(a => a.RoleAccounts)
                .HasForeignKey(ra => ra.AccountName);

            modelBuilder.Entity<Food>()
                .HasRequired(x => x.Category)
                .WithMany()
                .HasForeignKey(x => x.FoodCategoryId)
                .WillCascadeOnDelete(true);

            modelBuilder.Entity<BillDetails>()
                .HasRequired(bd => bd.Bill)
                .WithMany(b => b.BillDetails)
                .HasForeignKey(bd => bd.InvoiceID);

            modelBuilder.Entity<BillDetails>()
                .HasRequired(bd => bd.Food)
                .WithMany()
                .HasForeignKey(bd => bd.FoodID);

            modelBuilder.Entity<Bills>()
                .HasRequired(b => b.Table)
                .WithMany(t => t.Bills)
                .HasForeignKey(b => b.TableID);
        }
    }
}
