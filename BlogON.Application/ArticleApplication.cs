using BlogON.Application.Contracts.Article;
using BlogON.Domain.Entities.Article;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogON.Application
{
    public class ArticleApplication : IArticleApplication
    {

        private readonly IArticleRepo _articleRepo;

        public ArticleApplication(IArticleRepo articleRepo)
        {
            _articleRepo = articleRepo;
        }

        public List<ArticleViewModel> GetArticles()
        {
            var article = _articleRepo.GetArticles();
            var result = new List<ArticleViewModel>();
            foreach (var item in article)
            {
                result.Add(new ArticleViewModel()
                {
                    Id = item.Id,
                    Title = item.Title,
                    Category = item.ArticleCategory.Title,
                    IsDelete = item.IsDelete,
                    CreationDate = item.CreationDate.ToString()

                });

            }

            return result;
        }
    }
}
