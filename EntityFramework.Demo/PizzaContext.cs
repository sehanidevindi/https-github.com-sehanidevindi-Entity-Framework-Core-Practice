using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace EntityFramework.Demo
{
    internal class PizzaContext : DbContext
    {
        private readonly string connectionString;
        public PizzaContext(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public DbSet<Pizza> Employees {get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
