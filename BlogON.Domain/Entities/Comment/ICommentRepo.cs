using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogON.Domain.Entities.Comment
{
    public interface ICommentRepo
    {
        List<Comment> GetComments();
        void AddComment(Comment comment);
        void Save();
        Comment GetComment(int id);
    }
}
