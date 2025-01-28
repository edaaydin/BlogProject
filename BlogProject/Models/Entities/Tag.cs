namespace MVC_BlogProject.Models.Entities
{
    public class Tag
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // Bir Tag'in birden fazla makalesi olabilir.
        public virtual List<Article> Articles { get; set; }
    }
}
