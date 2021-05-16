using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogON.Application.Contracts.Comment;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BlogON.Presentation.Areas.Admin.Pages.CommentManagement
{
    public class DetailModel : PageModel
    {
        [BindProperty]
        public CommentDetail CommentView { get; set; }

        private readonly ICommentApplication _commentApplication;

        public DetailModel(ICommentApplication commentApplication)
        {
            _commentApplication = commentApplication;
        }

        public void OnGet(int id)
        {
            CommentView = _commentApplication.GetComment(id);
        }
    }
}
