using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogON.Domain.Entities.ArticleCategory;

namespace BlogON.Domain.Entities.Article
{
    public class Article
    {
        public int Id { get; private set; }
        public string Title { get; private set; }
        public string ShortDescription { get; private set; }
        public string Image { get; private set; }
        public string Content { get; private set; }
        public bool IsDelete { get; private set; }
        public DateTime CreationDate { get; private set; }


        public int ArticleCategoryId { get; set; }
        public ArticleCategory.ArticleCategory ArticleCategory { get; set; }


        public Article(string title,string shortDescription, string image, string content, int articleCategoryId)
        {
            Title = title;
            ShortDescription = shortDescription;
            Image = image;
            Content = content;
            ArticleCategoryId = articleCategoryId;
            IsDelete = false;
            CreationDate = DateTime.Now;
        }
    }
}
