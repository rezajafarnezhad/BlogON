using BlogON.Domain.Entities.Article;
using BlogON.Domain.Entities.ArticleCategory;
using BlogON.Domain.Entities.Comment;
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
        public DbSet<Article> Articles { get; set; }
        public DbSet<Comment> Comments  { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            var assembly = typeof(ArticleMapping).Assembly;
            modelBuilder.ApplyConfigurationsFromAssembly(assembly);

            
            base.OnModelCreating(modelBuilder);
        }



    }
}
