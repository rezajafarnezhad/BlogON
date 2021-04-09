﻿using BlogON.Domain.Entities.ArticleCategory;
using BlogON.Infra.EFcore.Mapping;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogON.Infra.EFcore
{
    public class BlogContext : DbContext
    {
        public BlogContext(DbContextOptions<BlogContext> options):base(options)
        {

        }

        public DbSet<ArticleCategory> ArticleCategories { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfiguration(new ArticleCaregoryMapping());

            base.OnModelCreating(modelBuilder);
        }



    }
}