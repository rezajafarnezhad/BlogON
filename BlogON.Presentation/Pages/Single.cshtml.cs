using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogON.Application.Contracts.Comment;
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
        private readonly ICommentApplication _commentApplication;

        public SingleModel(IArticleQuery articleQuery, ICommentApplication commentApplication)
        {
            _articleQuery = articleQuery;
            _commentApplication = commentApplication;
        }

        public void OnGet(int id)
        {
            articleQueryView = _articleQuery.GetArticle(id);
        }

        public IActionResult OnPost(AddComment comment)
        {
            _commentApplication.AddComment(comment);
            return RedirectToPage("Single",new { id=comment.ArticleId});
        }

    }
}
