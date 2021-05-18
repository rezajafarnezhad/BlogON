using BlogON.Domain.Entities.Article;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogON.Infra.EFcore.Mapping
{
    public class ArticleMapping : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            builder.ToTable("Articles");
            builder.HasKey(c => c.Id);
            builder.Property(c=>c.ShortDescription).HasMaxLength(600).IsRequired();
            builder.Property(c=>c.Title).HasMaxLength(170).IsRequired();
            builder.Property(c=>c.Content).IsRequired();
            builder.Property(c=>c.dateTime).IsRequired();
            builder.Property(c=>c.IsDelete).IsRequired();

            builder.HasOne(c => c.ArticleCategory).WithMany(c => c.Articles).HasForeignKey(c => c.ArticleCategoryId);
            builder.HasMany(c => c.Comments).WithOne(c => c.Article).HasForeignKey(c=>c.ArticleId);


        }
    }
}
