using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogON.Domain.Entities.Article
{
    public interface IArticleRepo
    {
        List<Article> GetArticles();
        void Create(Article article);
        void Save();
    }
}
