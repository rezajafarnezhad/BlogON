
using BlogON.Domain.Entities.ArticleCategory;
using BlogON.Infra.EFcore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace BlogON.Infra.EFcore.Repository
{
    public class ArticleCategoryRepo : IArticleCategoryRepo
    {

        private readonly BlogContext _context;

        public ArticleCategoryRepo(BlogContext context)
        {
            _context = context;
        }

        public void CreateArticleCategory(ArticleCategory articleCategory)
        {
            _context.ArticleCategories.Add(articleCategory);
          
        }

        public bool Exists(string title)
        {
            return _context.ArticleCategories.Any(c => c.Title == title);
        }

        public List<ArticleCategory> GetAllAtrticelCategory()
        {
            return _context.ArticleCategories.OrderByDescending(c => c.Id).ToList();
        }

        public ArticleCategory GetArticleCategoryBy(int id)
        {
            return _context.ArticleCategories.Find(id);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
