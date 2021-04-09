using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogON.Application.Contracts.ArticleCategory;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BlogON.Presentation.Areas.Admin.Pages.ArticleCategory
{
    public class EditModel : PageModel
    {

        [BindProperty]
        public EditCategory EditCategory { get; set; }


        private readonly IArticleCategoryApplication _articleCategory;

        public EditModel(IArticleCategoryApplication articleCategory)
        {
            _articleCategory = articleCategory;
        }

        public IActionResult OnGet(int id)
        {
            EditCategory = _articleCategory.Get(id);
            return Page();
        }

        public IActionResult OnPost(EditCategory editCategory)
        {
            _articleCategory.Edit(editCategory);
            return RedirectToPage("Index");
        }
    }
}
