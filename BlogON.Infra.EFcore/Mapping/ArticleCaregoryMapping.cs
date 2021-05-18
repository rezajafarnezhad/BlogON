using BlogON.Domain.Entities.ArticleCategory;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlogON.Infra.EFcore.Mapping
{
    public class ArticleCaregoryMapping : IEntityTypeConfiguration<ArticleCategory>
    {
        public void Configure(EntityTypeBuilder<ArticleCategory> builder)
        {
            builder.ToTable("ArticleCategories");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Title);
            builder.Property(c => c.dateTime);
            builder.Property(c => c.IsDeleted);
            builder.HasMany(c => c.Articles).WithOne(c => c.ArticleCategory).HasForeignKey(c => c.ArticleCategoryId);

        }
    }
}
