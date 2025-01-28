namespace MVC_BlogProject.Models.Repositories.Abstract
{
    public interface IGenericRepo<T> where T : class
    {
        void Insert(T entity); // Ekleme
        void Delete(T entity); // Silme
        void Update(T entity); // Güncelleme
        List<T> GetList(); // Listeleyerek hepini getirme.
        T GetById(int id); // id ile getirme
    }
}
