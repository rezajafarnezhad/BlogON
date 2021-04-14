using BlogON.Infra.EFcore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogON.infra.Query
{
    public interface IArticleCategoryQueryView
    {
        List<ArticleCategory> GetArticleCategory();
        List<ArticleQueryView> Artchive(int categoryid);
    }

    public class ArticleCategoryQueryView : IArticleCategoryQueryView
    {
        private readonly BlogContext _context;

        public ArticleCategoryQueryView(BlogContext context)
        {
            _context = context;
        }

        public List<ArticleQueryView> Artchive(int categoryid)
        {
            return _context.Articles.Include(c => c.ArticleCategory)
                .Where(c => c.ArticleCategoryId == categoryid).Select(c => new ArticleQueryView()
                {
                    Id = c.Id,
                    CreationDate=c.CreationDate.ToString(),
                    ShortDescription =c.ShortDescription,
                    Category = c.ArticleCategory.Title,
                    Image=c.Image,
                    Title=c.Title
                }).ToList();
        }

        public List<ArticleCategory> GetArticleCategory()
        {
            return _context.ArticleCategories.Select(c => new ArticleCategory()
            {
                Id =c.Id,
                Title = c.Title

            }).ToList();
        }
    }
}
