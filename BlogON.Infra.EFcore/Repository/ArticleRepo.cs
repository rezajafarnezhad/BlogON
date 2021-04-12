using BlogON.Domain.Entities.Article;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogON.Infra.EFcore.Repository
{
    public class ArticleRepo:IArticleRepo
    {
        private readonly BlogContext _context;

        public ArticleRepo(BlogContext context)
        {
            _context = context;
        }

        public void Create(Article article)
        {
            _context.Add(article);
        }

      

        public Article GetArticleById(int id)
        {
            return _context.Articles.Find(id);
        }

        public List<Article> GetArticles()
        {
            return _context.Articles.Include(c=>c.ArticleCategory).ToList();
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
