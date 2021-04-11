using BlogON.Domain.Entities.Article;
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
    }
}
