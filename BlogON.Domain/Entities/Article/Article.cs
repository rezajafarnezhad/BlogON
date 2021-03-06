using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01_FrameWork.Domain;
using BlogON.Domain.Entities.ArticleCategory;

namespace BlogON.Domain.Entities.Article
{
    public class Article : DomainBase<int>
    {
        
        public string Title { get; private set; }
        public string ShortDescription { get; private set; }
        public string Image { get; private set; }
        public string Content { get; private set; }
        public bool IsDelete { get; private set; }
      


        public int ArticleCategoryId { get; set; }
        public ArticleCategory.ArticleCategory ArticleCategory { get; set; }

        public ICollection<Comment.Comment> Comments { get; set; }


        public Article(string title, string shortDescription, string image, string content, int articleCategoryId)
        {
            Title = title;
            ShortDescription = shortDescription;
            Image = image;
            Content = content;
            ArticleCategoryId = articleCategoryId;
            IsDelete = false;
           
            Comments = new List<Comment.Comment>();
        }
        public void Edit(string title, string shortDescription, string image, string content, int articleCategoryId)
        {
            Title = title;
            ShortDescription = shortDescription;
            Image = image;
            Content = content;
            ArticleCategoryId = articleCategoryId;

        }

        public void Remove()
        {
            IsDelete = true;
        }
        public void Activate()
        {
            IsDelete = false;
        }

        public Article()
        {

        }
    }
}
