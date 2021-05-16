using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogON.Application.Contracts.Comment
{
    public class CommentViewModel
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Comment { get; set; }
        public int Status { get; set; }
        public string CreationDate { get; set; }
        public string Article { get; set; }
        public int ArticleId { get; set; }
    }
}
