

using BlogON.Application;
using BlogON.Application.Contracts.Article;
using BlogON.Application.Contracts.ArticleCategory;
using BlogON.Application.Contracts.Comment;
using BlogON.Domain.Entities.Article;
using BlogON.Domain.Entities.ArticleCategory;
using BlogON.Domain.Entities.Comment;
using BlogON.infra.Query;
using BlogON.Infra.EFcore;
using BlogON.Infra.EFcore.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace BlogON.Infra.Core
{


    public class BootStrapper
    {
        public static void Config(IServiceCollection services , string ConnectionString)
        {

            #region AddDbContext
            services.AddDbContext<BlogContext>(options => options.UseSqlServer(ConnectionString));

            #endregion
            
            #region Article

            services.AddTransient<IArticleRepo,ArticleRepo>();
            services.AddTransient<IArticleApplication, ArticleApplication>();

            #endregion



            
            #region ArticleCategory
            services.AddTransient<IArticleCategoryRepo, ArticleCategoryRepo>();
            services.AddTransient<IArticleCategoryApplication, ArticleCategoryApplication>();

            #endregion

            #region Query

            services.AddTransient<IArticleQuery, ArticleQuery>();
            services.AddTransient<IArticleCategoryQueryView, ArticleCategoryQueryView>();

            #endregion

            #region Comment

            services.AddTransient<ICommentRepo, CommentRepo>();
            services.AddTransient<ICommentApplication, CommentApplication>();

            #endregion


        }


    }



}
