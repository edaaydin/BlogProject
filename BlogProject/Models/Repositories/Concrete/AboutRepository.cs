using BlogProject.Models.Repositories.Abstract;
using MVC_BlogProject.Models.Context;
using MVC_BlogProject.Models.Entities;
using MVC_BlogProject.Models.Repositories.Abstract;
using MVC_BlogProject.Models.Repositories.Concrete;

namespace BlogProject.Models.Repositories.Concrete
{
    public class AboutRepository : GenericRepository<About>, IAboutRepo
    {
        public AboutRepository(BlogDbContext context) : base(context)
        {
        }

    }
}
