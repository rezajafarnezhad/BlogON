using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogON.infra.Query;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BlogON.Presentation.Pages
{
    public class SingleModel : PageModel
    {
        [BindProperty]
        public ArticleQueryView articleQueryView { get; set; }

        private readonly IArticleQuery _articleQuery;

        public SingleModel(IArticleQuery articleQuery)
        {
            _articleQuery = articleQuery;
        }

        public void OnGet(int id)
        {
            articleQueryView = _articleQuery.GetArticle(id);
        }
    }
}
