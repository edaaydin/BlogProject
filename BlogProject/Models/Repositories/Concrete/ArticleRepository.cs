using Microsoft.EntityFrameworkCore;
using MVC_BlogProject.Models.Context;
using MVC_BlogProject.Models.DTOs;
using MVC_BlogProject.Models.Entities;
using MVC_BlogProject.Models.Repositories.Abstract;

namespace MVC_BlogProject.Models.Repositories.Concrete
{
    public class ArticleRepository : GenericRepository<Article>, IArticleRepo
    {
        public ArticleRepository(BlogDbContext context) : base(context) { }
        public List<ArticleDTO> GetArticlesWithTags()
        {
            // Makaleleri ve etiketlerini almak için
            return _context.Articles
                .Include(a => a.Tags)  // Etiketleri de dahil et
                .Select(a => new ArticleDTO
                {
                    Id = a.Id,
                    Title = a.Title,
                    Content = a.Content,
                    CategoryId = a.CategoryId,  // CategoryId'yi alıyoruz
                    Tags = a.Tags.Select(t => t.Name).ToList()  // Etiketlerin adlarını alıyoruz
                })
                .ToList();
        }
    }
}

// protected yapınca oldu