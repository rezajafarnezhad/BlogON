using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogON.Application.Contracts.Comment;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BlogON.Presentation.Areas.Admin.Pages.CommentManagement
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public List<CommentViewModel> commentViewModels { get; set; }

        private readonly ICommentApplication _commentApplication;
        public IndexModel(ICommentApplication commentApplication)
        {
            _commentApplication = commentApplication;
        }

        public void OnGet()
        {
            commentViewModels = _commentApplication.GetComments();
            ViewData["Articleid"] = commentViewModels.FirstOrDefault().ArticleId;
        }

        public IActionResult OnPostConfirm(int id)
        {
            _commentApplication.Confirm(id);
            return RedirectToPage("Index");

        }

        public IActionResult OnPostCancel(int id)
        {
            _commentApplication.Cancel(id);
            return RedirectToPage("Index");


        }
    }
}
