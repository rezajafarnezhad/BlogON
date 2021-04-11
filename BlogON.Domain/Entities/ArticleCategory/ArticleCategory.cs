
using System;
using System.Collections.Generic;

namespace BlogON.Domain.Entities.ArticleCategory
{
    public class ArticleCategory
    {
        public int Id { get; private set; }
        public string Title { get; private set; }
        public bool IsDeleted { get; private set; }
        public DateTime CreationDate { get; private set; }


        public ICollection<Article.Article> Articles { get; set; }


        public void GuardAgainsEmptytitle(string title)
        {
            if (string.IsNullOrWhiteSpace(title))
            {
                throw new AccessViolationException();
            }
        }
        public ArticleCategory(string title)
        {
            GuardAgainsEmptytitle(title);
           
            Title = title;
            IsDeleted = false;
            CreationDate = DateTime.Now;
            Articles = new List<Article.Article>();
                
        }


        public void Edit(string title)
        {
            GuardAgainsEmptytitle(title);
            Title = title;

        }

        public void Remove()
        {

            IsDeleted =true;
        }

        public void Activate()
        {
            IsDeleted = false;
        }




    }



    

}
