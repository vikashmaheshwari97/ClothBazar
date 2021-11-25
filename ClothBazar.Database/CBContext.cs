﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using ClothBazar.Entities;

namespace ClothBazar.Database
{
    public class CBContext : DbContext,IDisposable
    {
        public CBContext(): base("ClothBazarConnection")
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products  { get; set; }
    }

}
