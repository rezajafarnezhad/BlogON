using System;
using System.Collections.Generic;
using System.Text;

namespace BlogON.Application.Contracts.ArticleCategory
{
    public interface IArticleCategoryApplication
    {
        List<ArticleCategoryViewModel> List();
        void Creat(CreateArticleCategory CreateArticleCategory);
        void Edit(EditCategory  editCategory);
        EditCategory Get(int id);
        void Remove(int id);
        void Active(int id);
    }
}
