namespace MVC_BlogProject.Models.Entities
{
    public class Article // makale
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int CategoryId { get; set; } // FK
        public Category Category { get; set; } // Bir makalenin bir kategorisi olur.

        // Bir makale birden fazla tag'e sahip olabilir
        public virtual List<Tag> Tags { get; set; }
    }
}
