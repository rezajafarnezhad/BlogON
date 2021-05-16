using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogON.Application.Contracts.Comment
{
    public interface ICommentApplication
    {
        void AddComment(AddComment Command);
        List<CommentViewModel> GetComments();
        CommentDetail GetComment(int id);
        void Confirm(int id);
        void Cancel(int id);
    }
}
