using MVC_BlogProject.Models.Context;
using MVC_BlogProject.Models.Entities;
using MVC_BlogProject.Models.Repositories.Abstract;

namespace MVC_BlogProject.Models.Repositories.Concrete
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepo
    {
        public CategoryRepository(BlogDbContext context) : base(context)
        {
        }
    }
}
