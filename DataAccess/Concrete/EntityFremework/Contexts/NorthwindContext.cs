﻿using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;  

namespace DataAccess.Concrete.EntityFremework.Contexts
{
    public class NorthwindContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString: @"Server=DESKTOP-0F3TA7A;Database=Northwind;Trusted_Connection=true");
        }
        public DbSet<Product> Products { get; set; }
    }
}
