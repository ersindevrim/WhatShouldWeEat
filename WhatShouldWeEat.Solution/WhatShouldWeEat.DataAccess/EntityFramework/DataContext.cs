using System;
using Microsoft.EntityFrameworkCore;
using WhatShouldWeEat.Entities;


namespace WhatShouldWeEat.DataAccess.EntityFramework
{
    public class DataContext : DbContext
    {
        override protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "User ID = fgtjtchj;Password = 8H1bUHfARAo9RD-kdV6oU9UuqeaueD59; Host = horton.elephantsql.com;Port = 5432;Database = fgtjtchj";
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
        public DbSet<stars> stars
        {
            get;
            set;
        }

        public DbSet<comments> comments
        {
            get;
            set;
        }
    }
}
