using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogON.infra.Query;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BlogON.Presentation.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public List<ArticleQueryView> articleQueryViews { get; set; }

        private readonly IArticleQuery _articleQuery;

        public IndexModel(IArticleQuery articleQuery)
        {
            _articleQuery = articleQuery;
        }

        public void OnGet()
        {
            articleQueryViews = _articleQuery.GetArticles();
        }
    }
}
