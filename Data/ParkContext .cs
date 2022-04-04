using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediaPark.Models;
using Microsoft.EntityFrameworkCore;

namespace MediaPark.Data
{
    public class ParkContext : DbContext
    {
        public ParkContext(DbContextOptions<ParkContext> options) : base(options)
        {
        }

        public DbSet<Branch> Branches { get; set; }
        public DbSet<Delivery> Deliveries { get; set; }
        public DbSet<Product> Products { get; set; }


        //adding to the table db
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Branch>().ToTable("Branch");
            modelBuilder.Entity<Delivery>().ToTable("Delivery");
            modelBuilder.Entity<Product>().ToTable("Product");
        }
    }
}
