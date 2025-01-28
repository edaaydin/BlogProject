using MVC_BlogProject.Models.DTOs;
using MVC_BlogProject.Models.Entities;

namespace MVC_BlogProject.Models.Repositories.Abstract
{
    public interface IArticleRepo : IGenericRepo<Article>
    {
        List<ArticleDTO> GetArticlesWithTags();
    }
}

