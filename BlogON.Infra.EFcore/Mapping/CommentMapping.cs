using BlogON.Domain.Entities.Comment;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogON.Infra.EFcore.Mapping
{
    public class CommentMapping : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.ToTable("Comments");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Message).HasMaxLength(800);
            builder.Property(c => c.Email).HasMaxLength(200);
            builder.Property(c => c.Name).HasMaxLength(200);

            builder.HasOne(c => c.Article).WithMany(c => c.Comments).HasForeignKey(c=>c.ArticleId);
        }
    }
}
