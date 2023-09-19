using LessonEF.Configurations;
using LessonEF.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonEF.Context
{
    public class MyDbContext : DbContext
    {
        // way 1
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=STHQ0116-01;Initial Catalog=PhoneShop;User ID=admin;Password=admin");
            base.OnConfiguring(optionsBuilder);
        }


        // way 2

        //public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        //{
        //}


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new OrderDetailConfiguration());
            //modelBuilder.ApplyConfiguration(new OrderConfiguration());
            //modelBuilder.ApplyConfiguration(new AppUserConfiguration());
            //modelBuilder.ApplyConfiguration(new AppUserDetailConfiguration());

            base.OnModelCreating(modelBuilder);
        }


        public DbSet<AppUser> Users { get; set; }
        public DbSet<AppUserDetail> UserDetails { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
