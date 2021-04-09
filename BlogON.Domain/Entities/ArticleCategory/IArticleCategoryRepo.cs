using System;
using System.Collections.Generic;
using System.Text;

namespace BlogON.Domain.Entities.ArticleCategory
{
    public interface IArticleCategoryRepo
    {
        List<ArticleCategory> GetAllAtrticelCategory();
        void CreateArticleCategory(ArticleCategory articleCategory);
        ArticleCategory GetArticleCategoryBy(int id);
        void Save();
        bool Exists(string title);
    }
}
