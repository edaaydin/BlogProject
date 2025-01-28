using MVC_BlogProject.Models.Context;
using MVC_BlogProject.Models.Entities;
using MVC_BlogProject.Models.Repositories.Abstract;

namespace MVC_BlogProject.Models.Repositories.Concrete
{
    public class TagRepository : GenericRepository<Tag>, ITagRepo
    {
        public TagRepository(BlogDbContext context) : base(context)
        {
        }
    }
}
