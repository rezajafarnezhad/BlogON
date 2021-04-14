using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogON.Domain.Entities.ArticleCategory;
using BlogON.infra.Query;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BlogON.Presentation.Pages
{
    public class ArchiveModel : PageModel
    {
        [BindProperty]
        public List<ArticleQueryView> articleQueryViews { get; set; }

        private readonly IArticleCategoryQueryView _articleCategoryQueryView;

        public ArchiveModel(IArticleCategoryQueryView articleCategoryQueryView)
        {
            _articleCategoryQueryView = articleCategoryQueryView;
        }

        public void OnGet(int id)
        {
            articleQueryViews = _articleCategoryQueryView.Artchive(id);
        }
    }
}
