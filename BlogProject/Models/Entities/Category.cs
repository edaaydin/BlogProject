namespace MVC_BlogProject.Models.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Article> Articles { get; set; } // bir kategorinin birden fazla makalesi olabilir.
    }
}
