using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogON.Application.Contracts.Article;
using BlogON.Application.Contracts.ArticleCategory;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BlogON.Presentation.Areas.Admin.Pages.Article
{
    public class EditModel : PageModel
    {
        [BindProperty]
        public EditArticle EditArticle { get; set; }

        public List<SelectListItem> selectListItems{ get; set; }

        private readonly IArticleApplication _articleApplication;
        private readonly IArticleCategoryApplication  _articleCategoryApplication;

        public EditModel(IArticleApplication articleApplication, IArticleCategoryApplication articleCategoryApplication)
        {
            _articleApplication = articleApplication;
            _articleCategoryApplication = articleCategoryApplication;
        }

        public void OnGet(int id)
        {

            EditArticle = _articleApplication.GetById(id);
            selectListItems = _articleCategoryApplication.List()
                .Select(c => new SelectListItem(c.Title, c.Id.ToString())).ToList();
            
        }

        public IActionResult OnPost(EditArticle EditArticle)
        {
            _articleApplication.Edit(EditArticle);
            return RedirectToPage("Index");
        }
    }
}
