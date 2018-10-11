using System;
using Microsoft.EntityFrameworkCore;
using WhatShouldWeEat.Entities;


namespace WhatShouldWeEat.DataAccess.EntityFramework
{
    public class DataContext : DbContext
    {
        override protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "YOUR CONNECTION STRING";
            optionsBuilder.UseNpgsql(connectionString);
        }

        public DbSet<carrier> carrier
        {
            get;
            set;
        }

        public DbSet<categories> categories
        {
            get;
            set;
        }

        public DbSet<dimensions> dimensions
        {
            get;
            set;
        }

        public DbSet<foods> foods
        {
            get;
            set;
        }

        public DbSet<metarials> metarials
        {
            get;
            set;
        }

        public DbSet<recepies> recepies
        {
            get;
            set;
        }

        public DbSet<users> users
        {
            get;
            set;
        }
    }
}
