using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogON.Application.Contracts.Article;
using BlogON.Application.Contracts.ArticleCategory;
using BlogON.Domain.Entities.ArticleCategory;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BlogON.Presentation.Areas.Admin.Pages.Article
{
    public class CreateModel : PageModel
    {
        public List<SelectListItem> selectListItems{ get; set; }
        private readonly IArticleCategoryApplication _articleCategoryApplication;
        private readonly IArticleApplication _articleApplication;

        public CreateModel(IArticleCategoryApplication articleCategoryApplication, IArticleApplication articleApplication)
        {
            _articleCategoryApplication = articleCategoryApplication;
            _articleApplication = articleApplication;
        }

        public void OnGet()
        {

            selectListItems =  _articleCategoryApplication.List()
                .Select(c => new SelectListItem(c.Title, c.Id.ToString())).ToList();

        }

        public IActionResult OnPost(CreateArticle createArticle)
        {
            _articleApplication.Create(createArticle);
            return Redirect("index");
        }
    }
}
