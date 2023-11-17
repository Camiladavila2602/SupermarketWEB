﻿using Microsoft.EntityFrameworkCore;
using SupermarkerWEB.Models;

namespace SupermarkerWEB.Data
{
    public class SupermarketContext: DbContext
    {
        public SupermarketContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

    }
}
