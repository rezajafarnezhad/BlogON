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
            builder.Property(c=>c.ShortDescription).HasMaxLength(190).IsRequired();
            builder.Property(c=>c.Title).HasMaxLength(120).IsRequired();
            builder.Property(c=>c.Content).IsRequired();
            builder.Property(c=>c.CreationDate).IsRequired();
            builder.Property(c=>c.IsDelete).IsRequired();

            builder.HasOne(c => c.ArticleCategory).WithMany(c => c.Articles).HasForeignKey(c => c.ArticleCategoryId);

        }
    }
}
