using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogON.Domain.Entities.Comment
{
    public class Comment
    {

        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Email { get; private set; }
        public string Message { get; private set; }
        public DateTime dateTime { get; private set; }
        public int Status { get; private set; } //new =0  , Confirmed =1 , cancle=2


        public int ArticleId { get; set; }
        public Article.Article Article { get; set; }

        public Comment(string name, string email, string message, int articleId)
        {
            Name = name;
            Email = email;
            Message = message;
            ArticleId = articleId;
            dateTime = DateTime.Now;
            Status = Statuses.New;
        }
        protected Comment()
        {

        }


        public void Confirm()
        {
            Status = Statuses.Confirmed;
        }
        public void Cancel()
        {
            Status = Statuses.Cancel;
        }
             
    }
}
