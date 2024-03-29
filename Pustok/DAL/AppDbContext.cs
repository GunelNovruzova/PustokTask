﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Pustok.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Pustok.DAL
{
    public class AppDbContext : IdentityDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public virtual DbSet<Slider> Sliders { get; set; }
        public virtual DbSet<UpPromotion> UpPromotions { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Genre> Genres { get; set; }
        public virtual DbSet<ProductImage> ProductImages { get; set; }
        public virtual DbSet<Setting> Settings { get; set; }
        public virtual DbSet<Tag> Tags { get; set; }
        public virtual DbSet<ProductTag> ProductTags { get; set; }
        public virtual DbSet<AppUser>  AppUsers{ get; set; }
    }
}
