using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogON.Application.Contracts.ArticleCategory;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BlogON.Presentation.Areas.Admin.Pages.ArticleCategory
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public List<ArticleCategoryViewModel> categoryViewModels { get; set; }

        IArticleCategoryApplication _articleCategory;

        public IndexModel(IArticleCategoryApplication articleCategory)
        {
            _articleCategory = articleCategory;
        }

        public void OnGet()
        {

            categoryViewModels = _articleCategory.List();

        }

        public IActionResult OnPostRemove(int id)
        {
            _articleCategory.Remove(id);
            return RedirectToPage("Index");
        }

        public IActionResult OnPostActive(int id)
        {
            _articleCategory.Active(id);
            return RedirectToPage("Index");
        }
    }
}
