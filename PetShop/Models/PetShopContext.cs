using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.Models
{
    public class PetShopContext : DbContext
    {
        public DbSet<Animals> Animals { get; set; }
        public DbSet<Suppliers> Suppliers { get; set; }
        public DbSet<Customers> Customers { get; set; }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder
       optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(
                    Environment.GetEnvironmentVariable("PETSHOP_CONNECTION_STRING")
                    ?? throw new InvalidOperationException("Set PETSHOP_CONNECTION_STRING before starting the application."));
            }
        }
    }

}
