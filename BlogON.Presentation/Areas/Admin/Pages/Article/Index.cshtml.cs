using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogON.Application.Contracts.Article;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BlogON.Presentation.Areas.Admin.Pages.Article
{
    public class IndexModel : PageModel
    {

        [BindProperty]
        public List<ArticleViewModel> articleViewModel { get; set; }

        private readonly IArticleApplication _articleApplication;

        public IndexModel(IArticleApplication articleApplication)
        {

            _articleApplication = articleApplication;
        }

        public void OnGet()
        {
            articleViewModel = _articleApplication.GetArticles();
        }


        public IActionResult OnPostRemove(int id)
        {
            _articleApplication.Remove(id);
            return RedirectToPage("Index");
        }

        public IActionResult OnPostActive(int id)
        {
            _articleApplication.Active(id);
            return RedirectToPage("Index");
        }
    }
}
