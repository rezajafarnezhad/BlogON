using BlogON.Infra.EFcore;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace BlogON.infra.Query
{
    public class ArticleQuery : IArticleQuery
    {
        private readonly BlogContext _context;

        public ArticleQuery(BlogContext context)
        {
            _context = context;
        }

        public ArticleQueryView GetArticle(int id)
        {
           
            return _context.Articles.Include(c=>c.ArticleCategory).Select(c=> new ArticleQueryView()
            {
                Id = c.Id,
                CreationDate=c.CreationDate.ToString(),
                ShortDescription = c.ShortDescription,
                Category=c.ArticleCategory.Title,
                Image=c.Image,
                Title=c.Title,
                Content = c.Content
            }).FirstOrDefault(c=>c.Id == id);
        }

        public List<ArticleQueryView> GetArticles()
        {
            return _context.Articles.Include(c => c.ArticleCategory).Select(c => new ArticleQueryView()
            {
                Id =c.Id,
                Title = c.Title,
                ShortDescription=c.ShortDescription,
                Category=c.ArticleCategory.Title,
                CreationDate=c.CreationDate.ToString(),
                Image=c.Image
                
            }).ToList();
        }
    }
}
