
using BlogON.Application.Contracts.Comment;
using BlogON.Domain.Entities.Comment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogON.Application
{
    public class CommentApplication : ICommentApplication
    {
        private readonly ICommentRepo _commentRepo;

        public CommentApplication(ICommentRepo commentRepo)
        {
            _commentRepo = commentRepo;
        }

        public void AddComment(AddComment Command)
        {
            var comment = new Comment(Command.Name, Command.Email, Command.Message, Command.ArticleId);
            _commentRepo.AddComment(comment);
            _commentRepo.Save();
        }

        public void Cancel(int id)
        {
            var comment = _commentRepo.GetComment(id);
            comment.Cancel();
            _commentRepo.Save();
        }

        public void Confirm(int id)
        {
            var Comment = _commentRepo.GetComment(id);
            Comment.Confirm();
            _commentRepo.Save();
        }

        public CommentDetail GetComment(int id)
        {
            var comment = _commentRepo.GetComment(id);
            return new CommentDetail()
            {
                Id = comment.Id,
                Message=comment.Message,
                
            };
        }

        public List<CommentViewModel> GetComments()
        {
            var comment = _commentRepo.GetComments();
            var result = new List<CommentViewModel>();
            foreach (var item in comment)
            {
                result.Add(new CommentViewModel()
                {
                    Id=item.Id,
                    Status=item.Status,
                    Article=item.Article.Title,
                    CreationDate=item.dateTime.ToString(),
                    Comment=item.Message,
                    Email=item.Email,
                    Name=item.Name,
                    ArticleId=item.ArticleId
                });
            }
            return result;
        }
    }
}
