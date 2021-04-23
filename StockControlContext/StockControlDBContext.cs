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
            modelBuilder.Entity<St_Stkjournal>().HasIndex(uniqueKey => uniqueKey.Stk_Coy).IsUnique();
        }
    }
}
