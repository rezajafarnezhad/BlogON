using BlogON.Domain.Entities.Comment;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogON.Infra.EFcore.Repository
{
    public class CommentRepo : ICommentRepo
    {
        private readonly BlogContext _context;

        public CommentRepo(BlogContext context)
        {
            _context = context;
        }

        public void AddComment(Comment comment)
        {
            _context.Comments.Add(comment);
        }

        public Comment GetComment(int id)
        {
            return _context.Comments.Find(id); 

        }

        public List<Comment> GetComments()
        {
            return _context.Comments.Include(c=>c.Article).OrderByDescending(c=>c.Id).ToList();
        }

        

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
