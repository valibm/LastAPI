﻿using Entity.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Product>? Products { get; set; }
        public DbSet<Image>? Images { get; set; }
        public DbSet<ProductImage>? ProductImages { get; set; }
    }
}
