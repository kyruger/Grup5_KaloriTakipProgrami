﻿using User;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CalorieTrackingDbContext:DbContext
    {
        public DbSet<User.User> Users { get; set; }
        public DbSet<Food> Foods { get; set; }
        public DbSet<ConsumedFood> ConsumedFoods { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseLazyLoadingProxies().UseSqlServer("Server = DESKTOP-3PIP4BH\\MSSQGLKD15;User ID=sa;Password=12345;Database=KaloriTakipDB;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(CalorieTrackingDbContext).Assembly);
        }
    }
}
