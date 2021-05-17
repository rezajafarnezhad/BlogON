using BlogON.Domain.Entities.Comment;
using BlogON.Infra.EFcore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BlogON.infra.Query
{
    public class ArticleQuery : IArticleQuery
    {
        private readonly BlogContext _context;

        public ArticleQuery(BlogContext context)
        {
            _context = context;
        }

        public ArticleQueryView GetArticle(int id)
        {
           
            return _context.Articles.Include(c=>c.ArticleCategory).Include(c=>c.Comments).Select(c=> new ArticleQueryView()
            {
                Id = c.Id,
                CreationDate=c.CreationDate.ToString(),
                ShortDescription = c.ShortDescription,
                Category=c.ArticleCategory.Title,
                Image=c.Image,
                Title=c.Title,
                Content = c.Content,
                CommentsCount = c.Comments.Count(c=>c.Status == Statuses.Confirmed),
                Comments = mapComments(c.Comments.Where(c => c.Status == Statuses.Confirmed))
            }).FirstOrDefault(c=>c.Id == id);
        }

        private static List<CommentQeuryView> mapComments(IEnumerable<Comment> comments)
        {
            var result = new List<CommentQeuryView>();
            foreach (var item in comments)
            {
                result.Add(new CommentQeuryView()
                {
                    Name = item.Name,
                    Comment=item.Message,
                    CreationDate=item.dateTime.ToString("dd/mm/yyyy")
                });

            }
            return result;
        }

        public List<ArticleQueryView> GetArticles()
        {
            return _context.Articles.Include(c => c.ArticleCategory)
                .Include(c=>c.Comments)
                .Select(c => new ArticleQueryView()
            {
                Id =c.Id,
                Title = c.Title,
                ShortDescription=c.ShortDescription,
                Category=c.ArticleCategory.Title,
                CreationDate=c.CreationDate.ToString(),
                Image=c.Image,
                CommentsCount = c.Comments.Count(c=>c.Status == Statuses.Confirmed),
                
            }).ToList();
        }
    }
}
