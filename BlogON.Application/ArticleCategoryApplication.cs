using BlogON.Application.Contracts.ArticleCategory;
using BlogON.Domain.Entities.ArticleCategory;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogON.Application
{
    public class ArticleCategoryApplication : IArticleCategoryApplication
    {

        private readonly IArticleCategoryRepo _ArcRep;
      

        public ArticleCategoryApplication(IArticleCategoryRepo arcRep)
        {
            _ArcRep = arcRep;
         
        }

        public void Active(int id)
        {
            var category = _ArcRep.GetArticleCategoryBy(id);
            category.Activate();
            _ArcRep.Save();
        }

        public void Remove(int id)
        {
            var category = _ArcRep.GetArticleCategoryBy(id);
            category.Remove();
            _ArcRep.Save();
        }

        public void Creat(CreateArticleCategory creatArticelCategory)
        {
            
                var articelCategory = new ArticleCategory(creatArticelCategory.Title);
                _ArcRep.CreateArticleCategory(articelCategory);
                _ArcRep.Save();
           

        }

        public void Edit(EditCategory editCategory)
        {
            try
            {
                var category = _ArcRep.GetArticleCategoryBy(editCategory.id);
                category.Edit(editCategory.Title);
                _ArcRep.Save();
            }
            catch (Exception)
            {
                throw new AccessViolationException();


            }
           


        }

        public EditCategory Get(int id)
        {
            var category = _ArcRep.GetArticleCategoryBy(id);
            return new EditCategory()
            {
                id = category.Id,
                Title = category.Title

            };

        }

        public List<ArticleCategoryViewModel> List()
        {

            var ArticelCategouries = _ArcRep.GetAllAtrticelCategory();

            var result = new List<ArticleCategoryViewModel>();

            foreach (var item in ArticelCategouries)
            {
                result.Add(new ArticleCategoryViewModel()
                {
                    Id = item.Id,
                    CreationDate = item.CreationDate.ToString(),
                    Title = item.Title,
                    IsDeleted = item.IsDeleted
                });
            }

            return result;

        }


    }
}
