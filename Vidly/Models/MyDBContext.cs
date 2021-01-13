﻿using System.Data.Entity;
namespace Vidly.Models
{
    public class MyDBContext : DbContext
    {
        public MyDBContext()
        {

        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Movie> Movies { get; set; }
    }
}