using MVC_BlogProject.Models.Context;
using MVC_BlogProject.Models.Repositories.Abstract;

namespace MVC_BlogProject.Models.Repositories.Concrete
{
    public class GenericRepository<T> : IGenericRepo<T> where T : class
    {
        protected readonly BlogDbContext _context;

        public GenericRepository(BlogDbContext context)
        {
            _context = context;
        }

        public void Delete(T entity)
        {
            _context.Remove(entity);
            _context.SaveChanges();
        }

        public T GetById(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public List<T> GetList()
        {
            return _context.Set<T>().ToList();
        }

        public void Insert(T entity)
        {
            _context.Set<T>().Add(entity);
            _context.SaveChanges();
        }

        public void Update(T entity)
        {
            _context.Update(entity);
            _context.SaveChanges();
        }
    }
}