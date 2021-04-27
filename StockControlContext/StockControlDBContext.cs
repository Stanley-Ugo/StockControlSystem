using Microsoft.EntityFrameworkCore;
using StockControlSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockControlSystem.StockControlContext
{
    public class StockControlDBContext : DbContext
    {
        public StockControlDBContext(DbContextOptions<StockControlDBContext> options) : base(options)
        {

        }

        public DbSet<Supplier> St_Supplier { get; set; }

        public DbSet<St_Stkjournal> St_Stkjournals { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Adding Unique Key Constraints to the below properties
            //modelBuilder.Entity<St_Stkjournal>().HasIndex(uniqueKey => uniqueKey.Stk_Coy).IsUnique();
            //modelBuilder.Entity<St_Stkjournal>().HasIndex(uniqueKey => uniqueKey.Stk_Branch).IsUnique();
            //modelBuilder.Entity<St_Stkjournal>().HasIndex(uniqueKey => uniqueKey.Stk_Year).IsUnique();
            //modelBuilder.Entity<St_Stkjournal>().HasIndex(uniqueKey => uniqueKey.Stk_Month).IsUnique();
            //modelBuilder.Entity<St_Stkjournal>().HasIndex(uniqueKey => uniqueKey.Stk_Loc).IsUnique();
            //modelBuilder.Entity<St_Stkjournal>().HasIndex(uniqueKey => uniqueKey.Stk_Type).IsUnique();
            //modelBuilder.Entity<St_Stkjournal>().HasIndex(uniqueKey => uniqueKey.Stk_Account).IsUnique();

            //Adding Multiple primary keys in the class
            modelBuilder.Entity<St_Stkjournal>().HasKey(st_stkjournal => new { st_stkjournal.Stk_Coy, st_stkjournal.Stk_Branch, st_stkjournal.Stk_Year,
                                                         st_stkjournal.Stk_Month, st_stkjournal.Stk_Loc, st_stkjournal.Stk_Type})

            //Makes the below property a "money" dataType in SQL Server
            modelBuilder.Entity<St_Stkjournal>().Property(s => s.Stk_Debit).HasColumnType("money");
            modelBuilder.Entity<St_Stkjournal>().Property(s => s.Stk_Credit).HasColumnType("money");

        }
    }
}
