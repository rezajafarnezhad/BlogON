using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogON.Application.Contracts.Article
{
    public interface IArticleApplication
    {
        List<ArticleViewModel> GetArticles();
        void Create(CreateArticle create);
    }
}
