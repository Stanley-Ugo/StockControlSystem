using Microsoft.EntityFrameworkCore;
using StockControlSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockControlSystem.StockControlContext
{
    public class StockControlContext : DbContext
    {
        public StockControlContext(DbContextOptions<StockControlContext> options) : base(options)
        {

        }

        public DbSet<Supplier> St_Supplier { get; set; }
    }
}
