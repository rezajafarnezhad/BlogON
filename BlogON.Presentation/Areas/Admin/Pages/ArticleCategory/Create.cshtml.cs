
using BlogON.Application.Contracts.ArticleCategory;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BlogON.Presentation.Areas.Admin.Pages.ArticleCategory
{
    public class CreateModel : PageModel
    {

        [BindProperty]
        public CreateArticleCategory createArticleCategory { get; set; }

        private readonly IArticleCategoryApplication _articleCategoryApplication;

        public CreateModel(IArticleCategoryApplication articleCategoryApplication)
        {
            _articleCategoryApplication = articleCategoryApplication;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        public IActionResult OnPost(CreateArticleCategory command)
        {

            _articleCategoryApplication.Creat(command);

            return RedirectToPage("index");




        }
    }
}
