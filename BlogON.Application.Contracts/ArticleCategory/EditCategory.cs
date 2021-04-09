using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogON.Application.Contracts.ArticleCategory
{
    public class EditCategory:CreateArticleCategory
    {
        public int id { get; set; }
    }
}
