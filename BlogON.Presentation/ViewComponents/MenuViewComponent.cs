using BlogON.infra.Query;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogON.Presentation.ViewComponents
{
    [ViewComponent(Name ="Menu")]
    public class MenuViewComponent : ViewComponent
    {

        private readonly IArticleCategoryQueryView _articleCategoryQueryView;

        public MenuViewComponent(IArticleCategoryQueryView articleCategoryQueryView)
        {
            _articleCategoryQueryView = articleCategoryQueryView;
        }

        public IViewComponentResult Invoke()
        {
            return View("Menu",_articleCategoryQueryView.GetArticleCategory());
        }
    }
}
